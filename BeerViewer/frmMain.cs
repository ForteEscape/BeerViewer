﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ImageFormat = System.Drawing.Imaging.ImageFormat;
using IServiceProvider = BeerViewer.Win32.IServiceProvider;
using VolumeMixer = BeerViewer.Models.VolumeMixer;
using Process = System.Diagnostics.Process;
using SHDocVw;

using BeerViewer.Core;
using BeerViewer.Views.Catalogs;

namespace BeerViewer
{
	public partial class frmMain : Form
	{
		public static frmMain Instance { get; private set; }
		public string CurrentTab { get; private set; }

		public System.Windows.Forms.WebBrowser Browser => this.browserMain;

		private Logger logger { get; }
		private OpenDB openDB { get; }

		private Dictionary<Label, Control> tabList { get; set; }
		public void UpdateTab(string TabName)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(() => UpdateTab(TabName));
				return;
			}

			CurrentTab = TabName;

			foreach (var item in tabList)
			{
				if (item.Value == contentBattle && Settings.BattleInfoLayout.Value)
					continue;

				if (layoutTab.Controls.Contains(item.Value))
					layoutTab.Controls.Remove(item.Value);

				item.Key.BackColor = Color.Transparent;
			}

			var TabButton = tabList.FirstOrDefault(x => TabName == x.Key.Name.Substring(3)).Key;
			if (TabButton == null) return;

			TabButton.BackColor = Color.FromArgb(81, 117, 142);

			layoutTab.Controls.Add(tabList[TabButton]);
			layoutTab.SetRow(tabList[TabButton], 1);
		}
		public void BuildTab(Label x, Control y)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(() => BuildTab(x, y));
				return;
			}

			var TabName = x.Name.Substring(3); // tabXXXX -> XXXX
			x.BackColor = Color.Transparent;
			x.Cursor = Cursors.Hand;
			tabList.Add(x, y);

			x.MouseEnter += (s, e) =>
			{
				if (CurrentTab == TabName) return;
				x.BackColor = Color.FromArgb(48, 144, 144, 144);
			};
			x.MouseLeave += (s, e) =>
			{
				if (CurrentTab == TabName) return;
				x.BackColor = Color.Transparent;
			};
			x.MouseDown += (s, e) => UpdateTab(TabName);
		}

		public frmMain()
		{
			InitializeComponent();

			frmMain.Instance = this;
			this.Text = Const.ApplicationName;

			MessageProvider.Instance.SetProvider(this);

			InitializeTabs();

			Helper.SetRegistryFeatureBrowserEmulation();
			Helper.PrepareBrowser(frmMain.Instance?.Browser);

			Action<bool> UpdateLayout = null;
			UpdateLayout = (x) =>
			{
				var browser = frmMain.Instance?.Browser;

				if (this.InvokeRequired)
				{
					this.Invoke(UpdateLayout);
					return;
				}

				if (Settings.VerticalMode.Value)
				{
					panelBrowser.Dock = DockStyle.Top;

					if (!Settings.BattleInfoLayout.Value)
						browser.Left = panelBrowser.ClientSize.Width / 2 - browser.ClientSize.Width / 2;

					else
					{
						browser.Left = 0;
						panelRemain.Padding = new Padding(browser.Width + 4, 0, 0, 0);
						contentBattle.Invalidate();
					}
				}
				else
				{
					panelBrowser.Dock = DockStyle.Left;
					browser.Left = 0;
					panelRemain.Padding = new Padding(0, browser.Height + 4, 0, 0);
				}

				if (x)
				{
					if (Settings.BattleInfoLayout.Value)
					{
						if (CurrentTab == "Battle")
							UpdateTab("General");

						if(contentBattle.Parent!=null)
							contentBattle.Parent.Controls.Remove(contentBattle);

						panelRemain.Controls.Add(contentBattle);
						panelRemain.Visible = true;

						tabBattle.Visible = false;
					}
					else
					{
						panelRemain.Controls.Remove(contentBattle);
						tabBattle.Visible = true;
					}
				}
			};
			panelBrowser.Resize += (s, e) => UpdateLayout(false);

			Translator.Initialize();

			DataStorage.Instance.Initialize();
			DataStorage.Instance.PropertyEvent(nameof(DataStorage.Initialized), () =>
			{
				this.contentGeneral.SetHomeport(DataStorage.Instance.Homeport);
				this.contentFleets.SetHomeport(DataStorage.Instance.Homeport);
			});

			Settings.VerticalMode.PropertyEvent(nameof(Settings.VerticalMode.Value), () => UpdateLayout(true), true);
			Settings.BattleInfoLayout.PropertyEvent(nameof(Settings.BattleInfoLayout.Value), () => UpdateLayout(true), true);

			{
				int x = this.Left, y = this.Top;
				int w = this.Width, h = this.Height;
				int state = (int)this.WindowState;

				if (Settings.Application_X.Value != int.MinValue) x = Settings.Application_X.Value;
				if (Settings.Application_Y.Value != int.MinValue) y = Settings.Application_Y.Value;
				if (Settings.Application_Width.Value != int.MinValue) w = Settings.Application_Width.Value;
				if (Settings.Application_Height.Value != int.MinValue) h = Settings.Application_Height.Value;
				if (Settings.Application_State.Value != int.MinValue) state = Settings.Application_State.Value;

				this.StartPosition = FormStartPosition.Manual;
				this.WindowState = (FormWindowState)state;
				this.Location = new Point(x, y);
				this.Size = new Size(w, h);
			}

			this.Move += (s, e) =>
			{
				Settings.Application_State.Value = (int)this.WindowState;
				if (this.WindowState != FormWindowState.Maximized)
				{
					Settings.Application_X.Value = this.Left;
					Settings.Application_Y.Value = this.Top;
				}
			};
			this.Resize += (s, e) =>
			{
				Settings.Application_State.Value = (int)this.WindowState;
				if (this.WindowState != FormWindowState.Maximized)
				{
					Settings.Application_Width.Value = this.Width;
					Settings.Application_Height.Value = this.Height;
				}
			};

			this.FormClosing += (s, e) =>
			{
				if (DataStorage.Instance?.IsInSortie ?? false)
				{
					if (MessageBox.Show("정말로 종료하시겠습니까?", Const.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
						e.Cancel = true;
				}
			};
			this.FormClosed += (s, e) => Application.Exit();

			VolumeMixer.SetApplicationMute(
				Process.GetCurrentProcess().Id,
				Settings.Application_Muted.Value
			);

			Settings.AlwaysOnTop.PropertyEvent(nameof(Settings.AlwaysOnTop.Value), () => this.TopMost = Settings.AlwaysOnTop.Value, true);

			Proxy.Instance.Register(e =>
			{
				if (!e.Request.PathAndQuery.StartsWith("/kcsapi/")) return;

				var x = e.TryParse(false);
				if (x == null || !x.IsSuccess)
				{
					MessageProvider.Instance.Submit(
						string.Format(
							"서버에서 {0} 오류를 전달했습니다.",
							x?.RawData.api_result ?? -1
						),
						Const.ApplicationName
					);
				}
			});

			this.Show();

			logger = new Logger();
			openDB = new OpenDB();
		}
		private void InitializeTabs()
		{
			tabList = new Dictionary<Label, Control>();

			CurrentTab = "";
			BuildTab(tabGeneral, contentGeneral);
			BuildTab(tabFleets, contentFleets);
			BuildTab(tabBattle, contentBattle);
			BuildTab(tabSettings, contentSettings);
			UpdateTab("General");
		}

		private void btnScreenshot_Click(object sender, EventArgs e)
		{
			var browser = frmMain.Instance?.Browser;

			var Captured = Helper.Capture(browser);
			if (Captured == null)
				MessageProvider.Instance.Submit("스크린샷 저장에 실패했습니다", Const.ApplicationName);

			else
			{
				var filename = $"BeerViewer-{DateTimeOffset.Now.LocalDateTime.ToString("yyyyMMdd-HHmmss-ff")}.png";
				var path = Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
					filename
				);
				try
				{
					Captured.Save(path, ImageFormat.Png);
					MessageProvider.Instance.Submit("스크린샷을 저장했습니다: " + filename, Const.ApplicationName);
				}
				catch
				{
					MessageProvider.Instance.Submit("스크린샷 저장에 실패했습니다", Const.ApplicationName);
				}
			}
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (DataStorage.Instance.IsInSortie)
			{
				if (MessageBox.Show("출격중입니다. 정말로 새로고침 하시겠습니까?", "BeerViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
					return;
			}

			if(Settings.RefreshImmediately.Value)
				frmMain.Instance?.Browser.Refresh(WebBrowserRefreshOption.Completely);
			else
				Helper.PrepareBrowser(frmMain.Instance?.Browser, true);
		}
		private void btnMute_Click(object sender, EventArgs e)
		{
			var pid = Process.GetCurrentProcess().Id;

			bool muted = !(VolumeMixer.GetApplicationMute(pid) ?? false);
			VolumeMixer.SetApplicationMute(pid, muted);

			muted = VolumeMixer.GetApplicationMute(pid) ?? false;
			if (muted)
				this.btnMute.BackgroundImage = Properties.Resources.Muted;
			else
				this.btnMute.BackgroundImage = Properties.Resources.Volume;

			Settings.Application_Muted.Value = muted;
		}

		public void SetBackColor(Color color)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(() => SetBackColor(color));
				return;
			}

			this.BackColor = color;
			this.contentSettings?.SetBackColor(color);
		}
		public void SetZoom(double zoomFactor)
		{
			try
			{
				var browser = frmMain.Instance?.Browser;

				var provider = browser.Document.DomDocument as IServiceProvider;
				if (provider == null) return;

				object ppvObject;
				provider.QueryService(typeof(IWebBrowserApp).GUID, typeof(IWebBrowser2).GUID, out ppvObject);
				var webBrowser = ppvObject as IWebBrowser2;
				if (webBrowser == null) return;

				object pvaIn = (int)(zoomFactor * 100);
				webBrowser.ExecWB(OLECMDID.OLECMDID_OPTICAL_ZOOM, OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, ref pvaIn);

				var dpiFactor = Helper.GetDPIFactor();
				browser.Size = new Size(
					(int)(800 * zoomFactor),// / dpiFactor),
					(int)(480 * zoomFactor)// / dpiFactor)
				);
				this.MinimumSize = new Size(
					browser.Size.Width + (this.Width - this.ClientSize.Width),
					browser.Size.Height + (this.Height - this.ClientSize.Height)
				);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				MessageProvider.Instance.Submit(
					string.Format("게임화면 크기 변경 실패: {0}", ex.Message),
					Const.ApplicationName
				);
			}
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F5)
				frmMain.Instance?.Browser.Refresh(WebBrowserRefreshOption.Completely);
		}
	}
}
