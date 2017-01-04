﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BeerViewer.Core;
using BeerViewer.Models.Raw;

namespace BeerViewer.Models
{
	public class SlotItem : RawDataWrapper<kcsapi_slotitem>, IIdentifiable
	{
		public int Id => this.RawData.api_id;
		public SlotItemInfo Info { get; private set; }

		public int Level => this.RawData.api_level;
		public string LevelText => this.Level >= 10 ? "★max" : this.Level >= 1 ? ("★+" + this.Level) : "";
		public string NameWithLevel => $"{this.Info.Name}{(this.Level >= 1 ? (" " + this.LevelText) : "")}{(this.Proficiency >= 1 ? (" " + this.ProficiencyText) : "")}";

		public int Proficiency => this.RawData.api_alv;
		public string ProficiencyText => this.Proficiency >= 1 ? (" (숙련도 " + this.Proficiency + ")") : "";

		internal SlotItem(kcsapi_slotitem RawData) : base(RawData)
		{
			this.Info = DataStorage.Instance.Master.SlotItems[this.RawData.api_slotitem_id] ?? SlotItemInfo.Dummy;
		}

		public void Remodel(int level, int masterId)
		{
			this.RawData.api_level = level;
			this.Info = DataStorage.Instance.Master.SlotItems[masterId] ?? SlotItemInfo.Dummy;

			this.RaisePropertyChanged(nameof(this.Info));
			this.RaisePropertyChanged(nameof(this.Level));
		}

		public override string ToString()
		{
			return $"ID = {this.Id}, Name = \"{this.Info.Name}\", Level = {this.Level}, Proficiency = {this.Proficiency}";
		}

		public static SlotItem Dummy { get; } = new SlotItem(new kcsapi_slotitem { api_slotitem_id = -1, });
	}
}
