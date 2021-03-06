﻿namespace BeerViewer.Views.Contents
{
	partial class SettingsView
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.layoutMain = new System.Windows.Forms.FlowLayoutPanel();
			this.optButtons = new System.Windows.Forms.FlowLayoutPanel();
			this.btnGameStart = new BeerViewer.Views.Controls.FlatButton();
			this.btnLogout = new BeerViewer.Views.Controls.FlatButton();
			this.btnCookie = new BeerViewer.Views.Controls.FlatButton();
			this.groupLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.chkAlwaysOnTop = new BeerViewer.Views.Controls.FlatCheckBox();
			this.optZoom = new System.Windows.Forms.FlowLayoutPanel();
			this.labelZoom = new System.Windows.Forms.Label();
			this.comboZoom = new BeerViewer.Views.Controls.FlatComboBox();
			this.optMainLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.labelMainLayout = new System.Windows.Forms.Label();
			this.comboMainLayout = new BeerViewer.Views.Controls.FlatComboBox();
			this.chkContentLayout = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkBattleInfoLayout = new BeerViewer.Views.Controls.FlatCheckBox();
			this.optViewRangeType = new System.Windows.Forms.FlowLayoutPanel();
			this.labelViewRangeType = new System.Windows.Forms.Label();
			this.comboViewRangeType = new BeerViewer.Views.Controls.FlatComboBox();
			this.labelViewRangeDescription = new System.Windows.Forms.Label();
			this.optViewRangeFleet = new System.Windows.Forms.FlowLayoutPanel();
			this.labelViewRangeFleet = new System.Windows.Forms.Label();
			this.chkViewRangeCalcFirstFleet = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkViewRangeCalcSecondFleet = new BeerViewer.Views.Controls.FlatCheckBox();
			this.groupNotification = new System.Windows.Forms.FlowLayoutPanel();
			this.chkExpeditionNotify = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkBuildNotify = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkRepairNotify = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkConditionNotify = new BeerViewer.Views.Controls.FlatCheckBox();
			this.groupBattleInfo = new System.Windows.Forms.FlowLayoutPanel();
			this.chkBattleInfoAutoSelectTab = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkBattleInfoDetailAirCombat = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkCriticalColor = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkGeneralAutoSelect = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkCriticalNotify = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkBattleEndNotify = new BeerViewer.Views.Controls.FlatCheckBox();
			this.groupETC = new System.Windows.Forms.FlowLayoutPanel();
			this.optFlashQuality = new System.Windows.Forms.FlowLayoutPanel();
			this.labelFlashQuality = new System.Windows.Forms.Label();
			this.comboFlashQuality = new BeerViewer.Views.Controls.FlatComboBox();
			this.labelFlashQualityDesc = new System.Windows.Forms.Label();
			this.chkUseOpenDB = new BeerViewer.Views.Controls.FlatCheckBox();
			this.chkRefreshImmediately = new BeerViewer.Views.Controls.FlatCheckBox();
			this.layoutMain.SuspendLayout();
			this.optButtons.SuspendLayout();
			this.groupLayout.SuspendLayout();
			this.optZoom.SuspendLayout();
			this.optMainLayout.SuspendLayout();
			this.optViewRangeType.SuspendLayout();
			this.optViewRangeFleet.SuspendLayout();
			this.groupNotification.SuspendLayout();
			this.groupBattleInfo.SuspendLayout();
			this.groupETC.SuspendLayout();
			this.optFlashQuality.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutMain
			// 
			this.layoutMain.AutoSize = true;
			this.layoutMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.layoutMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
			this.layoutMain.Controls.Add(this.optButtons);
			this.layoutMain.Controls.Add(this.groupLayout);
			this.layoutMain.Controls.Add(this.groupNotification);
			this.layoutMain.Controls.Add(this.groupBattleInfo);
			this.layoutMain.Controls.Add(this.groupETC);
			this.layoutMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.layoutMain.Location = new System.Drawing.Point(0, 0);
			this.layoutMain.Margin = new System.Windows.Forms.Padding(0);
			this.layoutMain.Name = "layoutMain";
			this.layoutMain.Padding = new System.Windows.Forms.Padding(4);
			this.layoutMain.Size = new System.Drawing.Size(269, 619);
			this.layoutMain.TabIndex = 1;
			// 
			// optButtons
			// 
			this.optButtons.AutoSize = true;
			this.optButtons.Controls.Add(this.btnGameStart);
			this.optButtons.Controls.Add(this.btnLogout);
			this.optButtons.Controls.Add(this.btnCookie);
			this.optButtons.Location = new System.Drawing.Point(4, 4);
			this.optButtons.Margin = new System.Windows.Forms.Padding(0);
			this.optButtons.Name = "optButtons";
			this.optButtons.Size = new System.Drawing.Size(250, 32);
			this.optButtons.TabIndex = 2;
			// 
			// btnGameStart
			// 
			this.btnGameStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.btnGameStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
			this.btnGameStart.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
			this.btnGameStart.DownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
			this.btnGameStart.Font = new System.Drawing.Font("맑은 고딕", 9F);
			this.btnGameStart.ForeColor = System.Drawing.Color.White;
			this.btnGameStart.Location = new System.Drawing.Point(2, 2);
			this.btnGameStart.Margin = new System.Windows.Forms.Padding(2);
			this.btnGameStart.Name = "btnGameStart";
			this.btnGameStart.OverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.btnGameStart.OverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
			this.btnGameStart.Size = new System.Drawing.Size(76, 28);
			this.btnGameStart.TabIndex = 7;
			this.btnGameStart.Text = "게임시작";
			this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
			this.btnLogout.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
			this.btnLogout.DownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
			this.btnLogout.Font = new System.Drawing.Font("맑은 고딕", 9F);
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(82, 2);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.OverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.btnLogout.OverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
			this.btnLogout.Size = new System.Drawing.Size(76, 28);
			this.btnLogout.TabIndex = 8;
			this.btnLogout.Text = "로그아웃";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnCookie
			// 
			this.btnCookie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.btnCookie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
			this.btnCookie.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
			this.btnCookie.DownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
			this.btnCookie.Font = new System.Drawing.Font("맑은 고딕", 9F);
			this.btnCookie.ForeColor = System.Drawing.Color.White;
			this.btnCookie.Location = new System.Drawing.Point(172, 2);
			this.btnCookie.Margin = new System.Windows.Forms.Padding(12, 2, 2, 2);
			this.btnCookie.Name = "btnCookie";
			this.btnCookie.OverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
			this.btnCookie.OverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
			this.btnCookie.Size = new System.Drawing.Size(76, 28);
			this.btnCookie.TabIndex = 9;
			this.btnCookie.Text = "쿠키설정";
			this.btnCookie.Click += new System.EventHandler(this.btnCookie_Click);
			// 
			// groupLayout
			// 
			this.groupLayout.AutoSize = true;
			this.groupLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupLayout.Controls.Add(this.chkAlwaysOnTop);
			this.groupLayout.Controls.Add(this.chkRefreshImmediately);
			this.groupLayout.Controls.Add(this.optZoom);
			this.groupLayout.Controls.Add(this.optMainLayout);
			this.groupLayout.Controls.Add(this.chkContentLayout);
			this.groupLayout.Controls.Add(this.chkBattleInfoLayout);
			this.groupLayout.Controls.Add(this.optViewRangeType);
			this.groupLayout.Controls.Add(this.labelViewRangeDescription);
			this.groupLayout.Controls.Add(this.optViewRangeFleet);
			this.groupLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.groupLayout.Location = new System.Drawing.Point(4, 46);
			this.groupLayout.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.groupLayout.Name = "groupLayout";
			this.groupLayout.Size = new System.Drawing.Size(261, 239);
			this.groupLayout.TabIndex = 2;
			// 
			// chkAlwaysOnTop
			// 
			this.chkAlwaysOnTop.AutoSize = true;
			this.chkAlwaysOnTop.Checked = true;
			this.chkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAlwaysOnTop.Location = new System.Drawing.Point(3, 3);
			this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
			this.chkAlwaysOnTop.Size = new System.Drawing.Size(131, 15);
			this.chkAlwaysOnTop.TabIndex = 24;
			this.chkAlwaysOnTop.Text = "창을 항상 위에 표시";
			this.chkAlwaysOnTop.UseVisualStyleBackColor = false;
			// 
			// optZoom
			// 
			this.optZoom.AutoSize = true;
			this.optZoom.Controls.Add(this.labelZoom);
			this.optZoom.Controls.Add(this.comboZoom);
			this.optZoom.Location = new System.Drawing.Point(0, 42);
			this.optZoom.Margin = new System.Windows.Forms.Padding(0);
			this.optZoom.Name = "optZoom";
			this.optZoom.Size = new System.Drawing.Size(239, 30);
			this.optZoom.TabIndex = 23;
			// 
			// labelZoom
			// 
			this.labelZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelZoom.AutoSize = true;
			this.labelZoom.Location = new System.Drawing.Point(3, 2);
			this.labelZoom.Name = "labelZoom";
			this.labelZoom.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.labelZoom.Size = new System.Drawing.Size(90, 25);
			this.labelZoom.TabIndex = 0;
			this.labelZoom.Text = "게임화면 크기 :";
			this.labelZoom.UseCompatibleTextRendering = true;
			// 
			// comboZoom
			// 
			this.comboZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.comboZoom.DropDownHeight = 2;
			this.comboZoom.IntegralHeight = false;
			this.comboZoom.Location = new System.Drawing.Point(99, 3);
			this.comboZoom.Name = "comboZoom";
			this.comboZoom.Size = new System.Drawing.Size(137, 24);
			this.comboZoom.TabIndex = 1;
			// 
			// optMainLayout
			// 
			this.optMainLayout.AutoSize = true;
			this.optMainLayout.Controls.Add(this.labelMainLayout);
			this.optMainLayout.Controls.Add(this.comboMainLayout);
			this.optMainLayout.Location = new System.Drawing.Point(0, 72);
			this.optMainLayout.Margin = new System.Windows.Forms.Padding(0);
			this.optMainLayout.Name = "optMainLayout";
			this.optMainLayout.Size = new System.Drawing.Size(175, 30);
			this.optMainLayout.TabIndex = 19;
			// 
			// labelMainLayout
			// 
			this.labelMainLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelMainLayout.AutoSize = true;
			this.labelMainLayout.Location = new System.Drawing.Point(3, 2);
			this.labelMainLayout.Name = "labelMainLayout";
			this.labelMainLayout.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.labelMainLayout.Size = new System.Drawing.Size(90, 25);
			this.labelMainLayout.TabIndex = 0;
			this.labelMainLayout.Text = "레이아웃 방향 :";
			this.labelMainLayout.UseCompatibleTextRendering = true;
			// 
			// comboMainLayout
			// 
			this.comboMainLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboMainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.comboMainLayout.DropDownHeight = 2;
			this.comboMainLayout.IntegralHeight = false;
			this.comboMainLayout.Location = new System.Drawing.Point(99, 3);
			this.comboMainLayout.Name = "comboMainLayout";
			this.comboMainLayout.Size = new System.Drawing.Size(73, 24);
			this.comboMainLayout.TabIndex = 1;
			// 
			// chkContentLayout
			// 
			this.chkContentLayout.AutoSize = true;
			this.chkContentLayout.Checked = true;
			this.chkContentLayout.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkContentLayout.Location = new System.Drawing.Point(3, 105);
			this.chkContentLayout.Name = "chkContentLayout";
			this.chkContentLayout.Size = new System.Drawing.Size(223, 15);
			this.chkContentLayout.TabIndex = 26;
			this.chkContentLayout.Text = "레이아웃 방향에 맞춰 탭 내용도 변경";
			this.chkContentLayout.UseVisualStyleBackColor = false;
			// 
			// chkBattleInfoLayout
			// 
			this.chkBattleInfoLayout.AutoSize = true;
			this.chkBattleInfoLayout.Checked = true;
			this.chkBattleInfoLayout.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBattleInfoLayout.Location = new System.Drawing.Point(3, 126);
			this.chkBattleInfoLayout.Name = "chkBattleInfoLayout";
			this.chkBattleInfoLayout.Size = new System.Drawing.Size(252, 15);
			this.chkBattleInfoLayout.TabIndex = 25;
			this.chkBattleInfoLayout.Text = "브라우저 옆/아래 공간에 전투 정보를 표시";
			this.chkBattleInfoLayout.UseVisualStyleBackColor = false;
			// 
			// optViewRangeType
			// 
			this.optViewRangeType.AutoSize = true;
			this.optViewRangeType.Controls.Add(this.labelViewRangeType);
			this.optViewRangeType.Controls.Add(this.comboViewRangeType);
			this.optViewRangeType.Location = new System.Drawing.Point(0, 154);
			this.optViewRangeType.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.optViewRangeType.Name = "optViewRangeType";
			this.optViewRangeType.Size = new System.Drawing.Size(247, 30);
			this.optViewRangeType.TabIndex = 20;
			// 
			// labelViewRangeType
			// 
			this.labelViewRangeType.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelViewRangeType.AutoSize = true;
			this.labelViewRangeType.Location = new System.Drawing.Point(3, 2);
			this.labelViewRangeType.Name = "labelViewRangeType";
			this.labelViewRangeType.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.labelViewRangeType.Size = new System.Drawing.Size(78, 25);
			this.labelViewRangeType.TabIndex = 0;
			this.labelViewRangeType.Text = "색적 계산식 :";
			this.labelViewRangeType.UseCompatibleTextRendering = true;
			// 
			// comboViewRangeType
			// 
			this.comboViewRangeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.comboViewRangeType.DropDownHeight = 2;
			this.comboViewRangeType.IntegralHeight = false;
			this.comboViewRangeType.Location = new System.Drawing.Point(87, 3);
			this.comboViewRangeType.Name = "comboViewRangeType";
			this.comboViewRangeType.Size = new System.Drawing.Size(157, 24);
			this.comboViewRangeType.TabIndex = 1;
			// 
			// labelViewRangeDescription
			// 
			this.labelViewRangeDescription.AutoSize = true;
			this.labelViewRangeDescription.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelViewRangeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
			this.labelViewRangeDescription.Location = new System.Drawing.Point(13, 184);
			this.labelViewRangeDescription.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
			this.labelViewRangeDescription.Name = "labelViewRangeDescription";
			this.labelViewRangeDescription.Size = new System.Drawing.Size(9, 19);
			this.labelViewRangeDescription.TabIndex = 22;
			this.labelViewRangeDescription.Text = "-";
			this.labelViewRangeDescription.UseCompatibleTextRendering = true;
			// 
			// optViewRangeFleet
			// 
			this.optViewRangeFleet.AutoSize = true;
			this.optViewRangeFleet.Controls.Add(this.labelViewRangeFleet);
			this.optViewRangeFleet.Controls.Add(this.chkViewRangeCalcFirstFleet);
			this.optViewRangeFleet.Controls.Add(this.chkViewRangeCalcSecondFleet);
			this.optViewRangeFleet.Location = new System.Drawing.Point(0, 216);
			this.optViewRangeFleet.Margin = new System.Windows.Forms.Padding(0, 13, 0, 0);
			this.optViewRangeFleet.Name = "optViewRangeFleet";
			this.optViewRangeFleet.Size = new System.Drawing.Size(261, 23);
			this.optViewRangeFleet.TabIndex = 21;
			// 
			// labelViewRangeFleet
			// 
			this.labelViewRangeFleet.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelViewRangeFleet.AutoSize = true;
			this.labelViewRangeFleet.Location = new System.Drawing.Point(3, 0);
			this.labelViewRangeFleet.Name = "labelViewRangeFleet";
			this.labelViewRangeFleet.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.labelViewRangeFleet.Size = new System.Drawing.Size(131, 23);
			this.labelViewRangeFleet.TabIndex = 0;
			this.labelViewRangeFleet.Text = "연합함대의 색적 계산 :";
			this.labelViewRangeFleet.UseCompatibleTextRendering = true;
			// 
			// chkViewRangeCalcFirstFleet
			// 
			this.chkViewRangeCalcFirstFleet.AutoSize = true;
			this.chkViewRangeCalcFirstFleet.Checked = true;
			this.chkViewRangeCalcFirstFleet.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkViewRangeCalcFirstFleet.Location = new System.Drawing.Point(140, 3);
			this.chkViewRangeCalcFirstFleet.Name = "chkViewRangeCalcFirstFleet";
			this.chkViewRangeCalcFirstFleet.Size = new System.Drawing.Size(54, 15);
			this.chkViewRangeCalcFirstFleet.TabIndex = 2;
			this.chkViewRangeCalcFirstFleet.Text = "1함대";
			this.chkViewRangeCalcFirstFleet.UseVisualStyleBackColor = false;
			// 
			// chkViewRangeCalcSecondFleet
			// 
			this.chkViewRangeCalcSecondFleet.AutoSize = true;
			this.chkViewRangeCalcSecondFleet.Checked = true;
			this.chkViewRangeCalcSecondFleet.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkViewRangeCalcSecondFleet.Location = new System.Drawing.Point(204, 3);
			this.chkViewRangeCalcSecondFleet.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
			this.chkViewRangeCalcSecondFleet.Name = "chkViewRangeCalcSecondFleet";
			this.chkViewRangeCalcSecondFleet.Size = new System.Drawing.Size(54, 15);
			this.chkViewRangeCalcSecondFleet.TabIndex = 3;
			this.chkViewRangeCalcSecondFleet.Text = "2함대";
			this.chkViewRangeCalcSecondFleet.UseVisualStyleBackColor = false;
			// 
			// groupNotification
			// 
			this.groupNotification.AutoSize = true;
			this.groupNotification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupNotification.Controls.Add(this.chkExpeditionNotify);
			this.groupNotification.Controls.Add(this.chkBuildNotify);
			this.groupNotification.Controls.Add(this.chkRepairNotify);
			this.groupNotification.Controls.Add(this.chkConditionNotify);
			this.groupNotification.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.groupNotification.Location = new System.Drawing.Point(4, 295);
			this.groupNotification.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.groupNotification.Name = "groupNotification";
			this.groupNotification.Size = new System.Drawing.Size(209, 84);
			this.groupNotification.TabIndex = 3;
			// 
			// chkExpeditionNotify
			// 
			this.chkExpeditionNotify.AutoSize = true;
			this.chkExpeditionNotify.Checked = true;
			this.chkExpeditionNotify.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkExpeditionNotify.Location = new System.Drawing.Point(3, 3);
			this.chkExpeditionNotify.Name = "chkExpeditionNotify";
			this.chkExpeditionNotify.Size = new System.Drawing.Size(151, 15);
			this.chkExpeditionNotify.TabIndex = 14;
			this.chkExpeditionNotify.Text = "원정에서 복귀하면 알림";
			this.chkExpeditionNotify.UseVisualStyleBackColor = false;
			// 
			// chkBuildNotify
			// 
			this.chkBuildNotify.AutoSize = true;
			this.chkBuildNotify.Checked = true;
			this.chkBuildNotify.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBuildNotify.Location = new System.Drawing.Point(3, 24);
			this.chkBuildNotify.Name = "chkBuildNotify";
			this.chkBuildNotify.Size = new System.Drawing.Size(139, 15);
			this.chkBuildNotify.TabIndex = 13;
			this.chkBuildNotify.Text = "건조가 완료되면 알림";
			this.chkBuildNotify.UseVisualStyleBackColor = false;
			// 
			// chkRepairNotify
			// 
			this.chkRepairNotify.AutoSize = true;
			this.chkRepairNotify.Checked = true;
			this.chkRepairNotify.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRepairNotify.Location = new System.Drawing.Point(3, 45);
			this.chkRepairNotify.Name = "chkRepairNotify";
			this.chkRepairNotify.Size = new System.Drawing.Size(139, 15);
			this.chkRepairNotify.TabIndex = 15;
			this.chkRepairNotify.Text = "입거가 완료되면 알림";
			this.chkRepairNotify.UseVisualStyleBackColor = false;
			// 
			// chkConditionNotify
			// 
			this.chkConditionNotify.AutoSize = true;
			this.chkConditionNotify.Checked = true;
			this.chkConditionNotify.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConditionNotify.Location = new System.Drawing.Point(3, 66);
			this.chkConditionNotify.Name = "chkConditionNotify";
			this.chkConditionNotify.Size = new System.Drawing.Size(203, 15);
			this.chkConditionNotify.TabIndex = 16;
			this.chkConditionNotify.Text = "함대의 피로회복이 완료되면 알림";
			this.chkConditionNotify.UseVisualStyleBackColor = false;
			// 
			// groupBattleInfo
			// 
			this.groupBattleInfo.AutoSize = true;
			this.groupBattleInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBattleInfo.Controls.Add(this.chkBattleInfoAutoSelectTab);
			this.groupBattleInfo.Controls.Add(this.chkBattleInfoDetailAirCombat);
			this.groupBattleInfo.Controls.Add(this.chkCriticalColor);
			this.groupBattleInfo.Controls.Add(this.chkGeneralAutoSelect);
			this.groupBattleInfo.Controls.Add(this.chkCriticalNotify);
			this.groupBattleInfo.Controls.Add(this.chkBattleEndNotify);
			this.groupBattleInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.groupBattleInfo.Location = new System.Drawing.Point(4, 389);
			this.groupBattleInfo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.groupBattleInfo.Name = "groupBattleInfo";
			this.groupBattleInfo.Size = new System.Drawing.Size(261, 136);
			this.groupBattleInfo.TabIndex = 4;
			// 
			// chkBattleInfoAutoSelectTab
			// 
			this.chkBattleInfoAutoSelectTab.AutoSize = true;
			this.chkBattleInfoAutoSelectTab.Checked = true;
			this.chkBattleInfoAutoSelectTab.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBattleInfoAutoSelectTab.Location = new System.Drawing.Point(3, 3);
			this.chkBattleInfoAutoSelectTab.Name = "chkBattleInfoAutoSelectTab";
			this.chkBattleInfoAutoSelectTab.Size = new System.Drawing.Size(167, 15);
			this.chkBattleInfoAutoSelectTab.TabIndex = 7;
			this.chkBattleInfoAutoSelectTab.Text = "전투 정보를 자동으로 선택";
			this.chkBattleInfoAutoSelectTab.UseVisualStyleBackColor = false;
			// 
			// chkBattleInfoDetailAirCombat
			// 
			this.chkBattleInfoDetailAirCombat.AutoSize = true;
			this.chkBattleInfoDetailAirCombat.Checked = true;
			this.chkBattleInfoDetailAirCombat.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBattleInfoDetailAirCombat.Location = new System.Drawing.Point(3, 24);
			this.chkBattleInfoDetailAirCombat.Name = "chkBattleInfoDetailAirCombat";
			this.chkBattleInfoDetailAirCombat.Size = new System.Drawing.Size(235, 15);
			this.chkBattleInfoDetailAirCombat.TabIndex = 8;
			this.chkBattleInfoDetailAirCombat.Text = "전투 정보에서 항공전 세부 정보를 표시";
			this.chkBattleInfoDetailAirCombat.UseVisualStyleBackColor = false;
			// 
			// chkCriticalColor
			// 
			this.chkCriticalColor.AutoSize = true;
			this.chkCriticalColor.Checked = true;
			this.chkCriticalColor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCriticalColor.Location = new System.Drawing.Point(3, 45);
			this.chkCriticalColor.Name = "chkCriticalColor";
			this.chkCriticalColor.Size = new System.Drawing.Size(255, 15);
			this.chkCriticalColor.TabIndex = 9;
			this.chkCriticalColor.Text = "전투 중 대파가 발생할 경우 뷰어 색을 변경";
			this.chkCriticalColor.UseVisualStyleBackColor = false;
			// 
			// chkGeneralAutoSelect
			// 
			this.chkGeneralAutoSelect.AutoSize = true;
			this.chkGeneralAutoSelect.Checked = true;
			this.chkGeneralAutoSelect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkGeneralAutoSelect.Location = new System.Drawing.Point(3, 76);
			this.chkGeneralAutoSelect.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
			this.chkGeneralAutoSelect.Name = "chkGeneralAutoSelect";
			this.chkGeneralAutoSelect.Size = new System.Drawing.Size(247, 15);
			this.chkGeneralAutoSelect.TabIndex = 18;
			this.chkGeneralAutoSelect.Text = "모항에 귀환하면 종합 탭을 자동으로 선택";
			this.chkGeneralAutoSelect.UseVisualStyleBackColor = false;
			// 
			// chkCriticalNotify
			// 
			this.chkCriticalNotify.AutoSize = true;
			this.chkCriticalNotify.Checked = true;
			this.chkCriticalNotify.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCriticalNotify.Location = new System.Drawing.Point(3, 97);
			this.chkCriticalNotify.Name = "chkCriticalNotify";
			this.chkCriticalNotify.Size = new System.Drawing.Size(199, 15);
			this.chkCriticalNotify.TabIndex = 16;
			this.chkCriticalNotify.Text = "전투 중 대파가 발생할 경우 알림";
			this.chkCriticalNotify.UseVisualStyleBackColor = false;
			// 
			// chkBattleEndNotify
			// 
			this.chkBattleEndNotify.AutoSize = true;
			this.chkBattleEndNotify.Checked = true;
			this.chkBattleEndNotify.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBattleEndNotify.Location = new System.Drawing.Point(3, 118);
			this.chkBattleEndNotify.Name = "chkBattleEndNotify";
			this.chkBattleEndNotify.Size = new System.Drawing.Size(139, 15);
			this.chkBattleEndNotify.TabIndex = 17;
			this.chkBattleEndNotify.Text = "전투가 종료되면 알림";
			this.chkBattleEndNotify.UseVisualStyleBackColor = false;
			// 
			// groupETC
			// 
			this.groupETC.AutoSize = true;
			this.groupETC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupETC.Controls.Add(this.optFlashQuality);
			this.groupETC.Controls.Add(this.labelFlashQualityDesc);
			this.groupETC.Controls.Add(this.chkUseOpenDB);
			this.groupETC.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.groupETC.Location = new System.Drawing.Point(4, 535);
			this.groupETC.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.groupETC.Name = "groupETC";
			this.groupETC.Size = new System.Drawing.Size(197, 80);
			this.groupETC.TabIndex = 5;
			// 
			// optFlashQuality
			// 
			this.optFlashQuality.AutoSize = true;
			this.optFlashQuality.Controls.Add(this.labelFlashQuality);
			this.optFlashQuality.Controls.Add(this.comboFlashQuality);
			this.optFlashQuality.Location = new System.Drawing.Point(0, 0);
			this.optFlashQuality.Margin = new System.Windows.Forms.Padding(0);
			this.optFlashQuality.Name = "optFlashQuality";
			this.optFlashQuality.Size = new System.Drawing.Size(191, 30);
			this.optFlashQuality.TabIndex = 21;
			// 
			// labelFlashQuality
			// 
			this.labelFlashQuality.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelFlashQuality.AutoSize = true;
			this.labelFlashQuality.Location = new System.Drawing.Point(3, 2);
			this.labelFlashQuality.Name = "labelFlashQuality";
			this.labelFlashQuality.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.labelFlashQuality.Size = new System.Drawing.Size(90, 25);
			this.labelFlashQuality.TabIndex = 0;
			this.labelFlashQuality.Text = "플래시 퀄리티 :";
			this.labelFlashQuality.UseCompatibleTextRendering = true;
			// 
			// comboFlashQuality
			// 
			this.comboFlashQuality.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboFlashQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
			this.comboFlashQuality.DropDownHeight = 2;
			this.comboFlashQuality.IntegralHeight = false;
			this.comboFlashQuality.Location = new System.Drawing.Point(99, 3);
			this.comboFlashQuality.Name = "comboFlashQuality";
			this.comboFlashQuality.Size = new System.Drawing.Size(89, 24);
			this.comboFlashQuality.TabIndex = 1;
			// 
			// labelFlashQualityDesc
			// 
			this.labelFlashQualityDesc.AutoSize = true;
			this.labelFlashQualityDesc.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelFlashQualityDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
			this.labelFlashQualityDesc.Location = new System.Drawing.Point(13, 30);
			this.labelFlashQualityDesc.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
			this.labelFlashQualityDesc.Name = "labelFlashQualityDesc";
			this.labelFlashQualityDesc.Size = new System.Drawing.Size(181, 19);
			this.labelFlashQualityDesc.TabIndex = 22;
			this.labelFlashQualityDesc.Text = "※ 게임을 새로고침해야 적용됩니다.";
			this.labelFlashQualityDesc.UseCompatibleTextRendering = true;
			// 
			// chkUseOpenDB
			// 
			this.chkUseOpenDB.AutoSize = true;
			this.chkUseOpenDB.Checked = true;
			this.chkUseOpenDB.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkUseOpenDB.Location = new System.Drawing.Point(3, 62);
			this.chkUseOpenDB.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
			this.chkUseOpenDB.Name = "chkUseOpenDB";
			this.chkUseOpenDB.Size = new System.Drawing.Size(188, 15);
			this.chkUseOpenDB.TabIndex = 23;
			this.chkUseOpenDB.Text = "OpenDB 서버에 데이터를 전송";
			this.chkUseOpenDB.UseVisualStyleBackColor = false;
			// 
			// chkRefreshImmediately
			// 
			this.chkRefreshImmediately.AutoSize = true;
			this.chkRefreshImmediately.Checked = true;
			this.chkRefreshImmediately.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRefreshImmediately.Location = new System.Drawing.Point(3, 24);
			this.chkRefreshImmediately.Name = "chkRefreshImmediately";
			this.chkRefreshImmediately.Size = new System.Drawing.Size(231, 15);
			this.chkRefreshImmediately.TabIndex = 27;
			this.chkRefreshImmediately.Tag = "chkRefreshI​mmediately";
			this.chkRefreshImmediately.Text = "시작화면으로 가지 않고 즉시 새로고침";
			this.chkRefreshImmediately.UseVisualStyleBackColor = false;
			// 
			// SettingsView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutMain);
			this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "SettingsView";
			this.Size = new System.Drawing.Size(433, 631);
			this.layoutMain.ResumeLayout(false);
			this.layoutMain.PerformLayout();
			this.optButtons.ResumeLayout(false);
			this.groupLayout.ResumeLayout(false);
			this.groupLayout.PerformLayout();
			this.optZoom.ResumeLayout(false);
			this.optZoom.PerformLayout();
			this.optMainLayout.ResumeLayout(false);
			this.optMainLayout.PerformLayout();
			this.optViewRangeType.ResumeLayout(false);
			this.optViewRangeType.PerformLayout();
			this.optViewRangeFleet.ResumeLayout(false);
			this.optViewRangeFleet.PerformLayout();
			this.groupNotification.ResumeLayout(false);
			this.groupNotification.PerformLayout();
			this.groupBattleInfo.ResumeLayout(false);
			this.groupBattleInfo.PerformLayout();
			this.groupETC.ResumeLayout(false);
			this.groupETC.PerformLayout();
			this.optFlashQuality.ResumeLayout(false);
			this.optFlashQuality.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel layoutMain;
		private System.Windows.Forms.FlowLayoutPanel optButtons;
		private Controls.FlatButton btnGameStart;
		private Controls.FlatButton btnLogout;
		private Controls.FlatButton btnCookie;
		private System.Windows.Forms.FlowLayoutPanel groupLayout;
		private Controls.FlatCheckBox chkAlwaysOnTop;
		private System.Windows.Forms.FlowLayoutPanel optZoom;
		private System.Windows.Forms.Label labelZoom;
		private Controls.FlatComboBox comboZoom;
		private System.Windows.Forms.FlowLayoutPanel optMainLayout;
		private System.Windows.Forms.Label labelMainLayout;
		private Controls.FlatComboBox comboMainLayout;
		private System.Windows.Forms.FlowLayoutPanel optViewRangeType;
		private System.Windows.Forms.Label labelViewRangeType;
		private Controls.FlatComboBox comboViewRangeType;
		private System.Windows.Forms.Label labelViewRangeDescription;
		private System.Windows.Forms.FlowLayoutPanel optViewRangeFleet;
		private System.Windows.Forms.Label labelViewRangeFleet;
		private Controls.FlatCheckBox chkViewRangeCalcFirstFleet;
		private Controls.FlatCheckBox chkViewRangeCalcSecondFleet;
		private System.Windows.Forms.FlowLayoutPanel groupNotification;
		private Controls.FlatCheckBox chkExpeditionNotify;
		private Controls.FlatCheckBox chkBuildNotify;
		private Controls.FlatCheckBox chkRepairNotify;
		private Controls.FlatCheckBox chkConditionNotify;
		private System.Windows.Forms.FlowLayoutPanel groupBattleInfo;
		private Controls.FlatCheckBox chkBattleInfoAutoSelectTab;
		private Controls.FlatCheckBox chkBattleInfoDetailAirCombat;
		private Controls.FlatCheckBox chkCriticalColor;
		private Controls.FlatCheckBox chkGeneralAutoSelect;
		private Controls.FlatCheckBox chkCriticalNotify;
		private Controls.FlatCheckBox chkBattleEndNotify;
		private System.Windows.Forms.FlowLayoutPanel groupETC;
		private System.Windows.Forms.FlowLayoutPanel optFlashQuality;
		private System.Windows.Forms.Label labelFlashQuality;
		private Controls.FlatComboBox comboFlashQuality;
		private System.Windows.Forms.Label labelFlashQualityDesc;
		private Controls.FlatCheckBox chkUseOpenDB;
		private Controls.FlatCheckBox chkBattleInfoLayout;
		private Controls.FlatCheckBox chkContentLayout;
		private Controls.FlatCheckBox chkRefreshImmediately;
	}
}
