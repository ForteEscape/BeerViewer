﻿namespace BeerViewer.Models.BattleInfo.Raw
{
	public class combined_battle_airbattle : ICommonFirstBattleMembers
	{
		public int api_deck_id { get; set; }
		public int[] api_ship_ke { get; set; }
		public int[] api_ship_lv { get; set; }
		public int[] api_nowhps { get; set; }
		public int[] api_maxhps { get; set; }
		public int[] api_nowhps_combined { get; set; }
		public int[] api_maxhps_combined { get; set; }
		public int api_midnight_flag { get; set; }
		public int[][] api_eSlot { get; set; }
		public int[][] api_eKyouka { get; set; }
		public int[][] api_fParam { get; set; }
		public int[][] api_eParam { get; set; }
		public int[][] api_fParam_combined { get; set; }
		public int[] api_search { get; set; }
		public int[] api_formation { get; set; }
		public Api_Air_Base_Attack[] api_air_base_attack { get; set; }
		public int[] api_stage_flag { get; set; }
		public Api_Kouku api_kouku { get; set; }
		public int api_support_flag { get; set; }
		public Api_Support_Info api_support_info { get; set; }
		public int[] api_stage_flag2 { get; set; }
		public Api_Kouku api_kouku2 { get; set; }
	}
}
