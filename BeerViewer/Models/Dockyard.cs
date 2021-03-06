﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BeerViewer.Core;
using BeerViewer.Models.Raw;

namespace BeerViewer.Models
{
	public class Dockyard : Notifier
	{
		#region Dock 프로퍼티
		private MemberTable<BuildingDock> _Docks;
		public MemberTable<BuildingDock> Docks
		{
			get { return this._Docks; }
			set
			{
				if (this._Docks != value)
				{
					this._Docks = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region CreatedSlotItem 프로퍼티
		private CreatedSlotItem _CreatedSlotItem;
		public CreatedSlotItem CreatedSlotItem
		{
			get { return this._CreatedSlotItem; }
			private set
			{
				if (this._CreatedSlotItem != value)
				{
					this._CreatedSlotItem = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion


		internal Dockyard()
		{
			var proxy = Proxy.Instance;
			this.Docks = new MemberTable<BuildingDock>();

			proxy.Register(Proxy.api_get_member_kdock, e =>
			{
				var x = e.TryParse<kcsapi_kdock[]>();
				if (x == null) return;

				this.Update(x.Data);
			});
			proxy.Register(Proxy.api_req_kousyou_getship, e =>
			{
				var x = e.TryParse<kcsapi_kdock_getship>();
				if (x == null) return;

				this.GetShip(x.Data);
			});
			proxy.Register(Proxy.api_req_kousyou_createship_speedchange, e =>
			{
				var x = e.TryParse();
				if (x == null) return;

				this.ChangeSpeed(x);
			});
			proxy.Register(Proxy.api_req_kousyou_createitem, e =>
			{
				var x = e.TryParse<kcsapi_createitem>();
				if (x == null) return;

				this.CreateSlotItem(x);
			});
		}

		internal void Update(kcsapi_kdock[] source)
		{
			if (this.Docks.Count == source.Length)
			{
				foreach (var raw in source) this.Docks[raw.api_id]?.Update(raw);
			}
			else
			{
				foreach (var dock in this.Docks) dock.Value?.Dispose();
				this.Docks = new MemberTable<BuildingDock>(source.Select(x => new BuildingDock(x)));
			}
		}

		private void GetShip(kcsapi_kdock_getship source)
		{
			this.Update(source.api_kdock);
		}

		private void ChangeSpeed(SvData svd)
		{
			try
			{
				var dock = this.Docks[int.Parse(svd.Request["api_kdock_id"])];
				var highspeed = svd.Request["api_highspeed"] == "1";

				if (highspeed) dock.Finish();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("고속수복제 사용 해석 실패: {0}", ex);
			}
		}

		private void CreateSlotItem(SvData<kcsapi_createitem> svd)
		{
			this.CreatedSlotItem = new CreatedSlotItem(svd.Data);
		}
	}
}
