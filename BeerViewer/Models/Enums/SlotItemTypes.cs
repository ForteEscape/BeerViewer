﻿namespace BeerViewer.Models.Enums
{
	public enum SlotItemTypes
	{
		None = 0,
		SmallCaliberMainGun = 1,
		MediumCaliberMainGun = 2,
		LargeCaliberMainGun = 3,
		SecondaryGun = 4,
		Torpedo = 5,
		CarrierBased_Fighter = 6,
		CarrierBased_DiveBomber = 7,
		CarrierBased_TorpedoBomber = 8,
		CarrierBased_ReconPlane = 9,
		ReconSeaplane = 10,
		SeaplaneBomber = 11,
		SmallRader = 12,
		LargeRader = 13,
		Sonar = 14,
		DepthCharge = 15, // ASW
		ExtraArmor = 16,
		EngineImprovement = 17,
		AAShell = 18,
		APShell = 19,
		VT_Fuse = 20,
		AAGun = 21,
		MidgetSubmarine = 22,
		DamageControl = 23,
		LandingCraft = 24,
		Autogyro = 25,
		AntiSubmarinePatrolAircraft = 26,
		ExtraArmor_Medium = 27,
		ExtraArmor_Large = 28,
		Searchlight = 29,
		DrumCanister = 30,
		RepairFacility = 31,
		SubmarineTorpedo = 32,
		Flare = 33,
		CommandFacility = 34,
		AviationPersonnel = 35,
		AAFireDirector = 36,
		AntiGroundEquipment = 37,
		LargeCaliberMainGun_II = 38,
		SurfaceShipPersonnel = 39,
		LargeSonar = 40,
		LargeFlyingBoat = 41,
		LargeSearchlight = 42,
		CombatRation = 43,
		OffshoreResupply = 44,
		SeaplaneFighter = 45,
		SpecialAmphibiousTank = 46,
		LandBased_Attacker = 47,
		Interceptor_Fighter = 48,
		JetPowered_Fighter = 56,
		JetPowered_FighterBomber = 57,
		JetPowered_Bomber = 58,
		JetPowered_ReconPlane = 59,
		LargeRader_II = 93,
		CarrierBased_ReconPlane_II = 94,
	}

	public static class SlotItemTypeExtensions
	{
		public static bool IsNumerable(this SlotItemTypes type)
		{
			switch (type)
			{
				case SlotItemTypes.CarrierBased_ReconPlane:
				case SlotItemTypes.CarrierBased_ReconPlane_II:
				case SlotItemTypes.CarrierBased_Fighter:
				case SlotItemTypes.CarrierBased_TorpedoBomber:
				case SlotItemTypes.CarrierBased_DiveBomber:
				case SlotItemTypes.ReconSeaplane:
				case SlotItemTypes.SeaplaneBomber:
				case SlotItemTypes.SeaplaneFighter:
				case SlotItemTypes.Autogyro:
				case SlotItemTypes.AntiSubmarinePatrolAircraft:
				case SlotItemTypes.LargeFlyingBoat:
				case SlotItemTypes.LandBased_Attacker:
				case SlotItemTypes.Interceptor_Fighter:
				case SlotItemTypes.JetPowered_Fighter:
				case SlotItemTypes.JetPowered_FighterBomber:
				case SlotItemTypes.JetPowered_Bomber:
				case SlotItemTypes.JetPowered_ReconPlane:
					return true;

				default:
					return false;
			}
		}
	}
}
