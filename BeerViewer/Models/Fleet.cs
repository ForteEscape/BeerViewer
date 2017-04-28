﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

using BeerViewer.Network;
using BeerViewer.Models.Raw;
using BeerViewer.Models.kcsapi;

namespace BeerViewer.Models
{
	public class Fleet : DisposableNotifier, IIdentifiable
	{
		private readonly Homeport homeport;
		private Ship[] originalShips;

		#region Id Property
		private int _Id;
		public int Id
		{
			get { return this._Id; }
			private set
			{
				if (this._Id != value)
				{
					this._Id = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region Name Property
		private string _Name;
		public string Name
		{
			get { return this._Name; }
			internal set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region Ships Property
		private Ship[] _Ships = new Ship[0];
		public Ship[] Ships
		{
			get { return this._Ships; }
			private set
			{
				if (this._Ships != value)
				{
					this._Ships = value;
					this.RaisePropertyChanged();
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public object ShipsUpdated { get; set; }
		#endregion

		public Expedition Expedition { get; }

		internal Fleet(Homeport parent, kcsapi_deck rawData)
		{
			this.homeport = parent;
			this.CompositeDisposable.Add(this.Expedition = new Expedition(this));

			this.Update(rawData);
		}

		internal void Update(kcsapi_deck rawData)
		{
			this.Id = rawData.api_id;
			this.Name = rawData.api_name;

			this.Expedition.Update(rawData.api_mission);
			this.UpdateShips(rawData.api_ship.Select(id => this.homeport.Organization.Ships[id]).ToArray());
		}

		#region Change, Unset
		internal Ship Change(int index, Ship ship)
		{
			var current = this.originalShips[index];

			List<Ship> list;
			if (index == -1)
			{
				list = this.originalShips.Take(1).ToList();
			}
			else
			{
				list = this.originalShips.ToList();
				list[index] = ship;
				list.RemoveAll(x => x == null);
			}

			var ships = new Ship[this.originalShips.Length];
			Array.Copy(list.ToArray(), ships, list.Count);

			this.UpdateShips(ships);

			return current;
		}

		internal void Unset(int index)
		{
			var list = this.originalShips.ToList();
			list[index] = null;
			list.RemoveAll(x => x == null);

			var ships = new Ship[this.originalShips.Length];
			Array.Copy(list.ToArray(), ships, list.Count);

			this.UpdateShips(ships);
		}

		internal void UnsetAll()
		{
			var list = this.originalShips.Take(1).ToList();
			var ships = new Ship[this.originalShips.Length];
			Array.Copy(list.ToArray(), ships, list.Count);

			this.UpdateShips(ships);
		}

		#endregion

		private void UpdateShips(Ship[] ships)
		{
			this.originalShips = ships;
			this.Ships = ships.Where(x => x != null).ToArray();
		}

		internal void RaiseShipsUpdated()
		{
			this.RaisePropertyChanged(nameof(this.ShipsUpdated));
		}

		public override string ToString()
		{
			return $"ID = {this.Id}, Name = \"{this.Name}\", Ships = {string.Join(",", this.Ships.Select(s => "\"" + s.Info.Name + "\""))}";
		}
	}
}
