﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerViewer.Models.Raw
{
	public class kcsapi_ship_deck
	{
		public kcsapi_ship2[] api_ship_data { get; set; }
		public kcsapi_deck[] api_deck_data { get; set; }
	}
}
