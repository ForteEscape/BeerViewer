﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BeerViewer.Core;
using BeerViewer.Models.Raw;

namespace BeerViewer.Models
{
	/// <summary>
	/// 艦隊の状態を表します。
	/// </summary>
	public class FleetState : DisposableNotifier
	{
		private readonly Homeport homeport;
		private readonly Fleet[] source;

		public FleetCondition Condition { get; }

		#region AverageLevel 프로퍼티
		private double _AverageLevel;
		public double AverageLevel
		{
			get { return this._AverageLevel; }
			private set
			{
				if (!this._AverageLevel.Equals(value))
				{
					this._AverageLevel = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region TotalLevel 프로퍼티
		private int _TotalLevel;
		public int TotalLevel
		{
			get { return this._TotalLevel; }
			private set
			{
				if (this._TotalLevel != value)
				{
					this._TotalLevel = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region EncounterPercent
		private double _EncounterPercent;
		public double EncounterPercent
		{
			get { return this._EncounterPercent; }
			private set
			{
				if (this._EncounterPercent != value)
				{
					this._EncounterPercent = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region PartEncounterPercent
		private List<SecondResult> _PartEncounterPercent;
		public List<SecondResult> PartEncounterPercent
		{
			get { return this._PartEncounterPercent; }
			private set
			{
				if (this._PartEncounterPercent != value)
				{
					this._PartEncounterPercent = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region FirstEncounter
		private double _FirstEncounter;
		public double FirstEncounter
		{
			get { return this._FirstEncounter; }
			private set
			{
				if (this._FirstEncounter != value)
				{
					this._FirstEncounter = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region MinAirSuperiorityPotential 프로퍼티
		private double _MinAirSuperiorityPotential;
		public double MinAirSuperiorityPotential
		{
			get { return this._MinAirSuperiorityPotential; }
			private set
			{
				if (this._MinAirSuperiorityPotential != value)
				{
					this._MinAirSuperiorityPotential = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region MaxAirSuperiorityPotential 프로퍼티
		private double _MaxAirSuperiorityPotential;
		public double MaxAirSuperiorityPotential
		{
			get { return this._MaxAirSuperiorityPotential; }
			private set
			{
				if (this._MaxAirSuperiorityPotential != value)
				{
					this._MaxAirSuperiorityPotential = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region ViewRange 프로퍼티
		private double _ViewRange;
		public double ViewRange
		{
			get { return this._ViewRange; }
			private set
			{
				if (this._ViewRange != value)
				{
					this._ViewRange = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region ViewRangeCalcType 프로퍼티
		private string _ViewRangeCalcType;
		public string ViewRangeCalcType
		{
			get { return this._ViewRangeCalcType; }
			set
			{
				if (this._ViewRangeCalcType != value)
				{
					this._ViewRangeCalcType = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region Speed 프로퍼티
		private FleetSpeed _Speed;
		public FleetSpeed Speed
		{
			get { return this._Speed; }
			set
			{
				if (this._Speed != value)
				{
					this._Speed = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region Situation 프로퍼티
		private FleetSituation _Situation;
		public FleetSituation Situation
		{
			get { return this._Situation; }
			private set
			{
				if (this._Situation != value)
				{
					this._Situation = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		#region IsReady 프로퍼티
		private bool _IsReady;
		public bool IsReady
		{
			get { return this._IsReady; }
			private set
			{
				if (this._IsReady != value)
				{
					this._IsReady = value;
					this.RaisePropertyChanged();
				}
			}
		}
		#endregion

		public bool InShortSupply => this.Situation.HasFlag(FleetSituation.InShortSupply);
		public bool HeavilyDamaged => this.Situation.HasFlag(FleetSituation.HeavilyDamaged);
		public bool Repairing => this.Situation.HasFlag(FleetSituation.Repairing);
		public bool FlagshipIsRepairShip => this.Situation.HasFlag(FleetSituation.FlagshipIsRepairShip);

		#region UsedFuel 프로퍼티
		private int _UsedFuel;
		public int UsedFuel
		{
			get { return this._UsedFuel; }
			set
			{
				this._UsedFuel = value;
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region UsedBull 프로퍼티
		private int _UsedBull;
		public int UsedBull
		{
			get { return this._UsedBull; }
			set
			{
				this._UsedBull = value;
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region UsedBauxite 프로퍼티
		private int _UsedBauxite;
		public int UsedBauxite
		{
			get { return this._UsedBauxite; }
			set
			{
				this._UsedBauxite = value;
				this.RaisePropertyChanged();
			}
		}
		#endregion

		public event EventHandler Updated;
		public event EventHandler Calculated;


		public FleetState(Homeport homeport, params Fleet[] fleets)
		{
			this.homeport = homeport;
			this.source = fleets ?? new Fleet[0];

			this.Condition = new FleetCondition();
			this.CompositeDisposable.Add(this.Condition);

			/*
			this.CompositeDisposable.Add(new PropertyChangedWeakEventListener(DataStorage.Instance.Settings)
			{
				{ nameof(IKanColleClientSettings.ViewRangeCalcType), (_, __) => this.Calculate() },
				{ nameof(IKanColleClientSettings.IsViewRangeCalcIncludeFirstFleet), (_, __) => this.Calculate() },
				{ nameof(IKanColleClientSettings.IsViewRangeCalcIncludeSecondFleet), (_, __) => this.Calculate() },
			});
			*/
		}


		public void Calculate()
		{
			var ships = this.source.SelectMany(x => x.Ships).WithoutEvacuated().ToArray();
			var firstFleetShips = this.source.FirstOrDefault()?.Ships.WithoutEvacuated().ToArray() ?? new Ship[0];

			List<SecondResult> partPercent = new List<SecondResult>();

			List<ShipSlot> SecondSlotList = new List<ShipSlot>(this.MakeSecondList(ships));
			List<SecondResult> TotalSecond = new List<SecondResult>(MakeSecondResult(SecondSlotList));

			List<int> HitList = new List<int>(this.MakeHitList(ships));
			for (int i = 0; i < HitList.Count; i++)
			{
				partPercent.Add(new SecondResult { Hit = HitList[i], SecondEncounter = TotalSecond.Where(x => x.Hit == HitList[i]).Sum(y => y.SecondEncounter) });
			}

			if (ships.HasItems())
			{
				this.UsedFuel = ships.Sum(x => x.UsedFuel);
				this.UsedBull = ships.Sum(x => x.UsedBull);
				this.UsedBauxite = ships.Sum(x =>
					x.Slots.Sum(y => y.Lost * 5)
				);
			}
			else this.UsedFuel = this.UsedBull = this.UsedBauxite = 0;

			this.TotalLevel = ships.HasItems() ? ships.Sum(x => x.Level) : 0;
			this.AverageLevel = ships.HasItems() ? (double)this.TotalLevel / ships.Length : 0.0;
			this.MinAirSuperiorityPotential = firstFleetShips.Sum(x => x.GetAirSuperiorityPotential(AirSuperiorityCalculationOptions.Minimum));
			this.MaxAirSuperiorityPotential = firstFleetShips.Sum(x => x.GetAirSuperiorityPotential(AirSuperiorityCalculationOptions.Maximum));
			this.EncounterPercent = TotalSecond.Sum(x => x.SecondEncounter);
			this.PartEncounterPercent = partPercent;
			this.FirstEncounter = ships.Sum(s => s.CalcFirstEncounterPercent());

			{
				if (ships.All(x => x.Speed == ShipSpeed.SuperFast)) // 최속으로만 구성
					this.Speed = FleetSpeed.SuperFast;
				else if (ships.All(x => x.Speed == ShipSpeed.FastPlus)) // 고속+로만 구성
					this.Speed = FleetSpeed.FastPlus;
				else if (ships.All(x => x.Speed == ShipSpeed.Fast)) // 고속으로만 구성
					this.Speed = FleetSpeed.Fast;
				else if (ships.All(x => x.Speed == ShipSpeed.Slow)) // 저속으로만 구성
					this.Speed = FleetSpeed.Slow;

				else if (!ships.Any(x => x.Speed == ShipSpeed.Fast || x.Speed == ShipSpeed.Slow)) // 최속&고속+ 구성
					this.Speed = FleetSpeed.Hybrid_FastPlus;
				else if (!ships.Any(x => x.Speed == ShipSpeed.Slow)) // 최속&고속+&고속 구성
					this.Speed = FleetSpeed.Hybrid_Fast;
				else
					this.Speed = FleetSpeed.Hybrid_Slow; // 저속 포함 구성
			}

			var logic = ViewRangeCalcLogic.Get(Settings.ViewRangeCalcType.Value);
			this.ViewRange = logic.Calc(this.source);
			this.ViewRangeCalcType = logic.Name;

			this.Calculated?.Invoke(this, new EventArgs());
		}
		private List<ShipSlot> MakeSecondList(Ship[] ships)
		{

			var aircraft = ships.Where(x => x.Info.IsAirCraft).ToList();
			List<int> HitList = new List<int>(this.MakeHitList(ships));
			List<ShipSlot> tempSlotList = new List<ShipSlot>();
			for (int j = 0; j < HitList.Count; j++)
			{
				foreach (var item in aircraft)
				{
					tempSlotList = tempSlotList.Concat(item.EquippedItems.Where(x => x.Item.Info.Hit == HitList[j] && x.Item.Info.IsSecondEncounter)).ToList();
				}
			}
			return tempSlotList;
		}
		private List<SecondResult> MakeSecondResult(List<ShipSlot> SecondSlotList)
		{
			List<SecondResult> templist = new List<SecondResult>();
			for (int i = 0; i < SecondSlotList.Count; i++)
			{
				SecondResult temp = new SecondResult();
				if (i == 0)
				{
					temp.SecondEncounter = SecondSlotList[i].Item.Info.SecondEncounter;
					temp.Hit = SecondSlotList[i].Item.Info.Hit;
					templist.Add(temp);
				}
				else
				{
					temp.SecondEncounter = (1 - templist.Sum(x => x.SecondEncounter)) * SecondSlotList[i].Item.Info.SecondEncounter;
					temp.Hit = SecondSlotList[i].Item.Info.Hit;
					templist.Add(temp);
				}
			}
			return templist;
		}

		private List<int> MakeHitList(Ship[] ships)
		{

			List<int> temp = new List<int>();
			for (int i = 0; i < ships.Count(); i++)
			{
				temp = temp.Concat(ships[i].HitStatusList()).ToList();
			}
			if (temp.Count <= 0) return new List<int>();
			temp = temp.Distinct().ToList();
			temp.Sort((int x, int y) => y.CompareTo(x));
			return temp;
		}

		public void Update()
		{
			var state = FleetSituation.Empty;
			var ready = true;

			var ships = this.source.SelectMany(x => x.Ships).ToArray();
			if (ships.Length == 0)
			{
				ready = false;
			}
			else
			{
				var first = this.source[0];

				if (this.source.Length == 1)
				{
					if (first.IsInSortie)
					{
						state |= FleetSituation.Sortie;
						ready = false;
					}
					else if (first.Expedition.IsInExecution)
					{
						state |= FleetSituation.Expedition;
						ready = false;
					}
					else
					{
						state |= FleetSituation.Homeport;
					}
				}
				else
				{
					state |= FleetSituation.Combined;

					if (first.IsInSortie)
					{
						state |= FleetSituation.Sortie;
						ready = false;
					}
					else
					{
						state |= FleetSituation.Homeport;
					}
				}
			}

			this.Condition.Update(ships);
			this.Condition.IsEnabled = state.HasFlag(FleetSituation.Homeport); // 疲労回復通知は母港待機中の艦隊でのみ行う

			if (state.HasFlag(FleetSituation.Homeport))
			{
				var repairing = ships.Any(x => this.homeport.Repairyard.CheckRepairing(x.Id));
				if (repairing)
				{
					state |= FleetSituation.Repairing;
					ready = false;
				}

				var inShortSupply = ships.Any(s => s.Fuel.Current < s.Fuel.Maximum || s.Bull.Current < s.Bull.Maximum);
				if (inShortSupply)
				{
					state |= FleetSituation.InShortSupply;
					ready = false;
				}

				if (this.Condition.IsRejuvenating)
				{
					ready = false;
				}
			}

			var heavilyDamaged = ships
				.Where(s => !this.homeport.Repairyard.CheckRepairing(s.Id))
				.Where(s => !s.Situation.HasFlag(ShipSituation.Evacuation) && !s.Situation.HasFlag(ShipSituation.Tow))
				.Where(s => !(state.HasFlag(FleetSituation.Sortie) && s.Situation.HasFlag(ShipSituation.DamageControlled)))
				.Any(s => s.HP.IsHeavilyDamage());
			if (heavilyDamaged)
			{
				state |= FleetSituation.HeavilyDamaged;
				ready = false;
			}

			var flagshipIsRepairShip = this.source
				.Where(x => x.Ships.Length >= 1)
				.Select(x => x.Ships[0])
				.Any(x => x.Info.ShipType.Id == 19);
			if (flagshipIsRepairShip)
			{
				state |= FleetSituation.FlagshipIsRepairShip;
				ready = false;
			}

			this.Situation = state;
			this.IsReady = ready;

			this.RaisePropertyChanged(nameof(this.InShortSupply));
			this.RaisePropertyChanged(nameof(this.HeavilyDamaged));
			this.RaisePropertyChanged(nameof(this.Repairing));
			this.RaisePropertyChanged(nameof(this.FlagshipIsRepairShip));

			this.Updated?.Invoke(this, new EventArgs());
		}
	}
	public class SecondResult
	{
		public int Hit { get; set; }
		public double SecondEncounter { get; set; }
	}
}
