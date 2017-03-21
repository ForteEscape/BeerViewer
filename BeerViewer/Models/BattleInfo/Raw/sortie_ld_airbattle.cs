﻿namespace BeerViewer.Models.BattleInfo.Raw
{
	public class sortie_ld_airbattle : ICommonFirstBattleMembers
	{
		public int api_dock_id { get; set; }
		public int[] api_ship_ke { get; set; }
		public int[] api_ship_lv { get; set; }
		public int[] api_nowhps { get; set; }
		public int[] api_maxhps { get; set; }
		public int api_midnight_flag { get; set; }
		public int[][] api_eSlot { get; set; }
		public int[][] api_eKyouka { get; set; }
		public int[][] api_fParam { get; set; }
		public int[][] api_eParam { get; set; }
		public int[] api_search { get; set; }
		public int[] api_formation { get; set; }
		public Api_Air_Base_Injection api_air_base_injection { get; set; }
		public Api_Injection_Kouku api_injection_kouku { get; set; }
		public Api_Air_Base_Attack[] api_air_base_attack { get; set; }
		public int[] api_stage_flag { get; set; }
		public Api_Kouku api_kouku { get; set; }
	}
}
