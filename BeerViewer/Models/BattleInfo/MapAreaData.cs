﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerViewer.Models.BattleInfo
{
	public class MapAreaData
	{
		public static Dictionary<string, string> MapAreaTable = new Dictionary<string, string>
		{
			//해역 1-1
			{"1-1-1", "A"},
			{"1-1-2", "B"},
			{"1-1-3", "C"},
			//해역 1-2
			{"1-2-1", "A"},
			{"1-2-2", "C"},
			{"1-2-3", "B"},
			{"1-2-4", "D"},
			//해역 1-3
			{"1-3-1", "A"},
			{"1-3-2", "B"},
			{"1-3-3", "D"},
			{"1-3-4", "C"},
			{"1-3-5", "E"},
			{"1-3-6", "F"},
			{"1-3-7", "G"},
			{"1-3-8", "C"},
			{"1-3-9", "F"},
			//해역 1-4
			{"1-4-1", "A"},
			{"1-4-2", "B"},
			{"1-4-3", "G"},
			{"1-4-4", "C"},
			{"1-4-5", "H"},
			{"1-4-6", "D"},
			{"1-4-7", "E"},
			{"1-4-8", "I"},
			{"1-4-9", "J"},
			{"1-4-10", "F"},
			{"1-4-11", "C"},
			{"1-4-12", "F"},
			{"1-4-13", "F"},
			//해역 1-5
			{"1-5-1", "A"},
			{"1-5-2", "B"},
			{"1-5-3", "D"},
			{"1-5-4", "C"},
			{"1-5-5", "E"},
			{"1-5-6", "F"},
			{"1-5-7", "H"},
			{"1-5-8", "G"},
			{"1-5-9", "I"},
			{"1-5-10", "I"},
			//해역 1-6
			{"1-6-1", "A"},
			{"1-6-2", "C"},
			{"1-6-3", "E"},
			{"1-6-4", "G"},
			{"1-6-5", "H"},
			{"1-6-6", "K"},
			{"1-6-7", "M"},
			{"1-6-8", "L"},
			{"1-6-9", "J"},
			{"1-6-10", "I"},
			{"1-6-11", "D"},
			{"1-6-12", "F"},
			{"1-6-13", "B"},
			{"1-6-14", "N"},
			{"1-6-15", "K"},
			{"1-6-16", "D"},
			{"1-6-17", "N"},
			//해역 2-1
			{"2-1-1", "A"},
			{"2-1-2", "B"},
			{"2-1-3", "D"},
			{"2-1-4", "C"},
			{"2-1-5", "F"},
			{"2-1-6", "E"},
			//해역 2-2
			{"2-2-1", "A"},
			{"2-2-2", "E"},
			{"2-2-3", "B"},
			{"2-2-4", "G"},
			{"2-2-5", "C"},
			{"2-2-6", "D"},
			{"2-2-7", "F"},
			{"2-2-8", "E"},
			//해역 2-3
			{"2-3-1", "C"},
			{"2-3-2", "A"},
			{"2-3-3", "H"},
			{"2-3-4", "D"},
			{"2-3-5", "B"},
			{"2-3-6", "E"},
			{"2-3-7", "I"},
			{"2-3-8", "J"},
			{"2-3-9", "K"},
			{"2-3-10", "F"},
			{"2-3-11", "G"},
			{"2-3-12", "E"},
			//해역 2-4
			{"2-4-1", "A"},
			{"2-4-2", "K"},
			{"2-4-3", "F"},
			{"2-4-4", "B"},
			{"2-4-5", "C"},
			{"2-4-6", "D"},
			{"2-4-7", "E"},
			{"2-4-8", "L"},
			{"2-4-9", "M"},
			{"2-4-10", "N"},
			{"2-4-11", "G"},
			{"2-4-12", "I"},
			{"2-4-13", "H"},
			{"2-4-14", "O"},
			{"2-4-15", "P"},
			{"2-4-16", "J"},
			{"2-4-17", "J"},
			{"2-4-18", "J"},
			{"2-4-19", "G"},
			//해역 2-5
			{"2-5-1", "A"},
			{"2-5-2", "B"},
			{"2-5-3", "C"},
			{"2-5-4", "F"},
			{"2-5-5", "D"},
			{"2-5-6", "E"},
			{"2-5-7", "G"},
			{"2-5-8", "H"},
			{"2-5-9", "I"},
			{"2-5-10", "J"},
			{"2-5-11", "K"},
			{"2-5-12", "L"},
			{"2-5-13", "H"},
			{"2-5-14", "H"},
			{"2-5-15", "L"},
			//해역 3-1
			{"3-1-1", "D"},
			{"3-1-2", "A"},
			{"3-1-3", "F"},
			{"3-1-4", "B"},
			{"3-1-5", "C"},
			{"3-1-6", "E"},
			//해역 3-2
			{"3-2-1", "E"},
			{"3-2-2", "A"},
			{"3-2-3", "D"},
			{"3-2-4", "F"},
			{"3-2-5", "B"},
			{"3-2-6", "C"},
			{"3-2-7", "G"},
			{"3-2-8", "H"},
			{"3-2-9", "B"},
			{"3-2-10", "F"},
			//해역 3-3
			{"3-3-1", "A"},
			{"3-3-2", "B"},
			{"3-3-3", "E"},
			{"3-3-4", "H"},
			{"3-3-5", "C"},
			{"3-3-6", "F"},
			{"3-3-7", "I"},
			{"3-3-8", "D"},
			{"3-3-9", "K"},
			{"3-3-10", "J"},
			{"3-3-11", "G"},
			{"3-3-12", "I"},
			{"3-3-13", "G"},
			//해역 3-4
			{"3-4-1", "A"},
			{"3-4-2", "J"},
			{"3-4-3", "K"},
			{"3-4-4", "B"},
			{"3-4-5", "F"},
			{"3-4-6", "L"},
			{"3-4-7", "G"},
			{"3-4-8", "M"},
			{"3-4-9", "C"},
			{"3-4-10", "H"},
			{"3-4-11", "N"},
			{"3-4-12", "D"},
			{"3-4-13", "I"},
			{"3-4-14", "O"},
			{"3-4-15", "E"},
			{"3-4-16", "F"},
			{"3-4-17", "L"},
			{"3-4-18", "H"},
			{"3-4-19", "H"},
			{"3-4-20", "E"},
			//해역 3-5
			{"3-5-1", "A"},
			{"3-5-2", "H"},
			{"3-5-3", "D"},
			{"3-5-4", "C"},
			{"3-5-5", "E"},
			{"3-5-6", "B"},
			{"3-5-7", "G"},
			{"3-5-8", "F"},
			{"3-5-9", "I"},
			{"3-5-10", "J"},
			{"3-5-11", "K"},
			{"3-5-12", "E"},
			{"3-5-13", "B"},
			{"3-5-14", "F"},
			{"3-5-15", "K"},
			//해역 4-1
			{"4-1-1", "E"},
			{"4-1-2", "A"},
			{"4-1-3", "H"},
			{"4-1-4", "F"},
			{"4-1-5", "I"},
			{"4-1-6", "B"},
			{"4-1-7", "G"},
			{"4-1-8", "C"},
			{"4-1-9", "D"},
			{"4-1-10", "I"},
			{"4-1-11", "I"},
			{"4-1-12", "D"},
			//해역 4-2
			{"4-2-1", "F"},
			{"4-2-2", "A"},
			{"4-2-3", "B"},
			{"4-2-4", "G"},
			{"4-2-5", "E"},
			{"4-2-6", "C"},
			{"4-2-7", "H"},
			{"4-2-8", "I"},
			{"4-2-9", "D"},
			{"4-2-10", "E"},
			{"4-2-11", "H"},
			{"4-2-12", "H"},
			{"4-2-13", "D"},
			//해역 4-3
			{"4-3-1", "J"},
			{"4-3-2", "A"},
			{"4-3-3", "B"},
			{"4-3-4", "F"},
			{"4-3-5", "K"},
			{"4-3-6", "C"},
			{"4-3-7", "D"},
			{"4-3-8", "G"},
			{"4-3-9", "H"},
			{"4-3-10", "L"},
			{"4-3-11", "E"},
			{"4-3-12", "M"},
			{"4-3-13", "I"},
			{"4-3-14", "F"},
			{"4-3-15", "F"},
			{"4-3-16", "K"},
			{"4-3-17", "D"},
			{"4-3-18", "D"},
			{"4-3-19", "G"},
			{"4-3-20", "G"},
			{"4-3-21", "L"},
			//해역 4-4
			{"4-4-1", "A"},
			{"4-4-2", "B"},
			{"4-4-3", "I"},
			{"4-4-4", "F"},
			{"4-4-5", "C"},
			{"4-4-6", "D"},
			{"4-4-7", "G"},
			{"4-4-8", "J"},
			{"4-4-9", "E"},
			{"4-4-10", "H"},
			{"4-4-11", "C"},
			{"4-4-12", "G"},
			{"4-4-13", "G"},
			{"4-4-14", "J"},
			//해역 4-5
			{"4-5-1", "A"},
			{"4-5-2", "B"},
			{"4-5-3", "D"},
			{"4-5-4", "C"},
			{"4-5-5", "E"},
			{"4-5-6", "F"},
			{"4-5-7", "G"},
			{"4-5-8", "H"},
			{"4-5-9", "I"},
			{"4-5-10", "J"},
			{"4-5-11", "L"},
			{"4-5-12", "K"},
			{"4-5-13", "M"},
			{"4-5-14", "C"},
			{"4-5-15", "F"},
			{"4-5-16", "F"},
			{"4-5-17", "H"},
			{"4-5-18", "J"},
			{"4-5-19", "M"},
			//해역 5-1
			{"5-1-1", "B"},
			{"5-1-2", "A"},
			{"5-1-3", "D"},
			{"5-1-4", "C"},
			{"5-1-5", "F"},
			{"5-1-6", "E"},
			{"5-1-7", "H"},
			{"5-1-8", "G"},
			{"5-1-9", "I"},
			{"5-1-10", "F"},
			{"5-1-11", "E"},
			{"5-1-12", "H"},
			//해역 5-2
			{"5-2-1", "A"},
			{"5-2-2", "B"},
			{"5-2-3", "F"},
			{"5-2-4", "G"},
			{"5-2-5", "E"},
			{"5-2-6", "C"},
			{"5-2-7", "I"},
			{"5-2-10", "D"},
			{"5-2-11", "G"},
			{"5-2-12", "H"},
			{"5-2-13", "J"},
			{"5-2-14", "D"},
			//해역 5-3
			{"5-3-1", "A"},
			{"5-3-2", "B"},
			{"5-3-3", "C"},
			{"5-3-4", "D"},
			{"5-3-5", "E"},
			{"5-3-6", "F"},
			{"5-3-7", "G"},
			{"5-3-8", "H"},
			{"5-3-9", "I"},
			{"5-3-10", "J"},
			{"5-3-11", "K"},
			{"5-3-12", "D"},
			{"5-3-13", "I"},
			{"5-3-14", "I"},
			//해역 5-4
			{"5-4-1", "A"},
			{"5-4-2", "B"},
			{"5-4-3", "C"},
			{"5-4-4", "F"},
			{"5-4-6", "I"},
			{"5-4-7", "E"},
			{"5-4-8", "D"},
			{"5-4-9", "L"},
			{"5-4-10", "N"},
			{"5-4-12", "H"},
			{"5-4-13", "K"},
			{"5-4-14", "J"},
			{"5-4-15", "O"},
			{"5-4-17", "H"},
			{"5-4-18", "M"},
			{"5-4-19", "O"},
			{"5-4-20", "O"},
			//해역 5-5
			{"5-5-1", "B"},
			{"5-5-2", "A"},
			{"5-5-3", "F"},
			{"5-5-4", "C"},
			{"5-5-5", "D"},
			{"5-5-10", "G"},
			{"5-5-12", "E"},
			{"5-5-13", "L"},
			{"5-5-14", "N"},
			{"5-5-17", "E"},
			{"5-5-18", "N"},
			//해역 6-1
			{"6-1-1", "G"},
			{"6-1-2", "A"},
			{"6-1-3", "B"},
			{"6-1-4", "C"},
			{"6-1-5", "D"},
			{"6-1-6", "E"},
			{"6-1-7", "H"},
			{"6-1-8", "F"},
			{"6-1-9", "I"},
			{"6-1-10", "J"},
			{"6-1-11", "K"},
			{"6-1-12", "D"},
			{"6-1-13", "D"},
			//해역 6-2
			{"6-2-1", "A"},
			{"6-2-2", "B"},
			{"6-2-3", "C"},
			{"6-2-4", "D"},
			{"6-2-5", "E"},
			{"6-2-6", "F"},
			{"6-2-7", "G"},
			{"6-2-8", "E"},
			{"6-2-9", "H"},
			{"6-2-10", "I"},
			{"6-2-11", "K"},
			{"6-2-12", "B"},
			{"6-2-13", "D"},
			{"6-2-14", "E"},
			{"6-2-15", "J"},
			{"6-2-16", "H"},
			{"6-2-17", "K"},
			{"6-2-18", "K"},
			//해역 6-3
			{"6-3-1", "A"},
			{"6-3-2", "B"},
			{"6-3-3", "C"},
			{"6-3-4", "D"},
			{"6-3-5", "E"},
			{"6-3-6", "F"},
			{"6-3-7", "G"},
			{"6-3-8", "H"},
			{"6-3-9", "I"},
			{"6-3-10", "J"},
			{"6-3-11", "E"},
			{"6-3-12", "H"},
			//해역 6-4
			{"6-4-1", "A"},
			{"6-4-2", "B"},
			{"6-4-3", "C"},
			{"6-4-4", "D"},
			{"6-4-5", "E"},
			{"6-4-6", "F"},
			{"6-4-7", "G"},
			{"6-4-8", "K"},
			{"6-4-9", "I"},
			{"6-4-10", "J"},
			{"6-4-11", "K"},
			{"6-4-12", "L"},
			{"6-4-13", "M"},
			{"6-4-14", "N"},
			{"6-4-15", "D"},
			{"6-4-16", "D"},
			{"6-4-17", "D"},
			{"6-4-18", "J"},
			{"6-4-19", "I"},
			{"6-4-20", "N"},
			{"6-4-21", "N"},

			{"6-5-1", "A"},
			{"6-5-2", "B"},
			{"6-5-3", "C"},
			{"6-5-4", "D"},
			{"6-5-5", "E"},
			{"6-5-6", "F"},
			{"6-5-7", "G"},
			{"6-5-9", "I"},
			{"6-5-10", "J"},
			{"6-5-13", "M"},
			{"6-5-15", "G"},
			{"6-5-16", "H"},
			{"6-5-17", "I"},
			{"6-5-18", "M"},

			//해역 31-1
			{"31-1-1", "A"},
			{"31-1-2", "B"},
			{"31-1-3", "C"},
			{"31-1-4", "D"},
			{"31-1-5", "E"},
			{"31-1-6", "F"},
			{"31-1-7", "G"},
			{"31-1-8", "Z"},
			{"31-1-9", "D"},
			{"31-1-10", "Z"},
			//해역 31-2
			{"31-2-1", "A"},
			{"31-2-2", "B"},
			{"31-2-3", "C"},
			{"31-2-4", "D"},
			{"31-2-5", "E"},
			{"31-2-6", "F"},
			{"31-2-7", "G"},
			{"31-2-8", "H"},
			{"31-2-9", "I"},
			{"31-2-10", "J"},
			{"31-2-13", "Z"},
			{"31-2-14", "G"},
			{"31-2-15", "H"},
			{"31-2-17", "Z"},
			//해역 31-3
			{"31-3-1", "A"},
			{"31-3-2", "B"},
			{"31-3-3", "C"},
			{"31-3-4", "D"},
			{"31-3-5", "E"},
			{"31-3-6", "F"},
			{"31-3-7", "G"},
			{"31-3-8", "H"},
			{"31-3-9", "I"},
			{"31-3-11", "X"},
			{"31-3-12", "Z"},
			{"31-3-13", "D"},
			{"31-3-14", "E"},
			{"31-3-16", "Z"},
			//해역 31-4
			{"31-4-1", "A"},
			{"31-4-2", "B"},
			{"31-4-3", "C"},
			{"31-4-4", "D"},
			{"31-4-5", "E"},
			{"31-4-6", "F"},
			{"31-4-7", "G"},
			{"31-4-8", "H"},
			{"31-4-9", "I"},
			{"31-4-10", "J"},
			{"31-4-13", "Z"},
			{"31-4-14", "E"},
			{"31-4-15", "H"},
			{"31-4-16", "H"},
			{"31-4-18", "Z"},
			//해역 31-5
			{"31-5-1", "A"},
			{"31-5-2", "B"},
			{"31-5-3", "C"},
			{"31-5-4", "D"},
			{"31-5-5", "E"},
			{"31-5-6", "F"},
			{"31-5-8", "H"},
			{"31-5-9", "I"},
			{"31-5-10", "J"},
			{"31-5-11", "K"},
			{"31-5-14", "Z"},
			{"31-5-15", "C"},
			{"31-5-16", "F"},
			//해역 31-6
			{"31-6-1", "A"},
			{"31-6-3", "C"},
			{"31-6-4", "D"},
			{"31-6-5", "E"},
			{"31-6-7", "G"},
			{"31-6-8", "H"},
			{"31-6-10", "J"},
			{"31-6-11", "K"},
			{"31-6-12", "L"},
			{"31-6-13", "M"},
			{"31-6-15", "O"},
			{"31-6-17", "Z"},
			{"31-6-19", "J"},
			{"31-6-20", "F"},
			{"31-6-22", "Z"},
			//해역 31-7
			{"31-7-1", "A"},
			{"31-7-2", "B"},
			{"31-7-3", "C"},
			{"31-7-4", "D"},
			{"31-7-5", "E"},
			{"31-7-6", "F"},
			{"31-7-7", "G"},
			{"31-7-8", "H"},
			{"31-7-9", "I"},
			{"31-7-10", "J"},
			{"31-7-11", "K"},
			{"31-7-12", "L"},
			{"31-7-13", "M"},
			{"31-7-17", "X"},
			{"31-7-18", "Y"},
			{"31-7-19", "Z"},
			{"31-7-20", "G"},
			{"31-7-21", "J"},
			{"31-7-22", "L"},
			{"31-7-23", "M"},
			{"31-7-25", "Y"},
			{"31-7-26", "Z"},
			//해역 32-1
			{"32-1-1", "A"},
			{"32-1-2", "B"},
			{"32-1-3", "C"},
			{"32-1-4", "D"},
			{"32-1-5", "E"},
			{"32-1-6", "F"},
			{"32-1-7", "I"},
			{"32-1-8", "H"},
			{"32-1-9", "G"},
			{"32-1-10", "J"},
			{"32-1-11", "C"},
			{"32-1-12", "F"},
			{"32-1-13", "H"},
			{"32-1-14", "J"},
			//해역 32-2
			{"32-2-1", "A"},
			{"32-2-2", "B"},
			{"32-2-3", "C"},
			{"32-2-4", "D"},
			{"32-2-5", "E"},
			{"32-2-6", "F"},
			{"32-2-7", "H"},
			{"32-2-8", "G"},
			{"32-2-9", "I"},
			{"32-2-10", "J"},
			{"32-2-11", "K"},
			{"32-2-12", "E"},
			{"32-2-13", "F"},
			{"32-2-14", "G"},
			{"32-2-15", "I"},
			{"32-2-16", "I"},
			{"32-2-17", "K"},
			//해역 32-3
			{"32-3-1", "A"},
			{"32-3-2", "B"},
			{"32-3-3", "C"},
			{"32-3-4", "D"},
			{"32-3-5", "E"},
			{"32-3-6", "F"},
			{"32-3-7", "G"},
			{"32-3-8", "H"},
			{"32-3-9", "I"},
			{"32-3-10", "J"},
			{"32-3-11", "K"},
			{"32-3-12", "E"},
			{"32-3-13", "G"},
			//해역 32-4
			{"32-4-1", "A"},
			{"32-4-2", "B"},
			{"32-4-3", "C"},
			{"32-4-4", "D"},
			{"32-4-5", "E"},
			{"32-4-6", "F"},
			{"32-4-7", "G"},
			{"32-4-8", "H"},
			{"32-4-9", "I"},
			{"32-4-10", "J"},
			{"32-4-11", "K"},
			{"32-4-12", "L"},
			{"32-4-13", "M"},
			{"32-4-14", "N"},
			{"32-4-15", "O"},
			{"32-4-16", "E"},
			{"32-4-17", "F"},
			{"32-4-18", "I"},
			{"32-4-19", "K"},
			//해역 32-5
			{"32-5-1", "A"},
			{"32-5-2", "B"},
			{"32-5-3", "C"},
			{"32-5-5", "E"},
			{"32-5-6", "F"},
			{"32-5-7", "G"},
			{"32-5-8", "H"},
			{"32-5-9", "I"},
			{"32-5-10", "J"},
			{"32-5-11", "K"},
			{"32-5-12", "L"},
			{"32-5-13", "M"},
			{"32-5-14", "N"},
			{"32-5-19", "J"},
			//해역 33-1
			{"33-1-1", "A"},
			{"33-1-2", "B"},
			{"33-1-3", "C"},
			{"33-1-4", "D"},
			{"33-1-5", "E"},
			{"33-1-6", "F"},
			{"33-1-7", "G"},
			{"33-1-8", "H"},
			{"33-1-9", "I"},
			{"33-1-10", "J"},
			{"33-1-11", "D"},
			{"33-1-12", "F"},
			//해역 33-2
			{"33-2-1", "A"},
			{"33-2-2", "B"},
			{"33-2-3", "C"},
			{"33-2-4", "D"},
			{"33-2-5", "E"},
			{"33-2-6", "F"},
			{"33-2-7", "G"},
			{"33-2-8", "H"},
			{"33-2-9", "I"},
			{"33-2-10", "J"},
			{"33-2-11", "K"},
			{"33-2-12", "L"},
			{"33-2-13", "M"},
			{"33-2-14", "N"},
			{"33-2-15", "O"},
			{"33-2-16", "F"},
			{"33-2-17", "G"},
			{"33-2-18", "J"},
			{"33-2-19", "L"},
			{"33-2-20", "M"},
			{"33-2-21", "O"},
			//해역 33-3
			{"33-3-1", "A"},
			{"33-3-2", "B"},
			{"33-3-3", "C"},
			{"33-3-4", "D"},
			{"33-3-5", "E"},
			{"33-3-6", "F"},
			{"33-3-7", "G"},
			{"33-3-8", "H"},
			{"33-3-9", "I"},
			{"33-3-10", "J"},
			{"33-3-11", "K"},
			{"33-3-12", "L"},
			{"33-3-13", "M"},
			{"33-3-14", "N"},
			{"33-3-16", "P"},
			{"33-3-17", "Q"},
			{"33-3-19", "S"},
			{"33-3-20", "T"},
			{"33-3-21", "D"},
			{"33-3-22", "I"},
			{"33-3-24", "T"},

			{"36-1-1", "A"},
			{"36-1-2", "B"},
			{"36-1-3", "C"},
			{"36-1-4", "D"},
			{"36-1-5", "E"},
			{"36-1-6", "F"},
			{"36-1-7", "G"},
			{"36-1-8", "H"},
			{"36-1-9", "I"},
			{"36-1-10", "J"},
			{"36-1-11", "K"},
			{"36-1-12", "L"},
			{"36-1-13", "E"},
			{"36-1-14", "E"},
			{"36-1-15", "F"},
			{"36-1-16", "H"},
			{"36-1-17", "H"},
			{"36-1-18", "L"},
			{"36-2-1", "A"},
			{"36-2-2", "B"},
			{"36-2-3", "C"},
			{"36-2-4", "D"},
			{"36-2-5", "E"},
			{"36-2-6", "F"},
			{"36-2-7", "G"},
			{"36-2-8", "H"},
			{"36-2-9", "I"},
			{"36-2-10", "J"},
			{"36-2-11", "K"},
			{"36-2-12", "L"},
			{"36-2-13", "M"},
			{"36-2-14", "N"},
			{"36-2-15", "O"},
			{"36-2-16", "F"},
			{"36-2-17", "F"},
			{"36-2-18", "G"},
			{"36-2-19", "H"},
			{"36-2-20", "I"},
			{"36-2-21", "I"},
			{"36-2-22", "O"},
			{"36-3-1", "A"},
			{"36-3-2", "B"},
			{"36-3-3", "C"},
			{"36-3-4", "D"},
			{"36-3-5", "E"},
			{"36-3-6", "F"},
			{"36-3-7", "G"},
			{"36-3-8", "H"},
			{"36-3-9", "I"},
			{"36-3-10", "J"},
			{"36-3-11", "K"},
			{"36-3-12", "L"},
			{"36-3-13", "M"},
			{"36-3-14", "N"},
			{"36-3-15", "O"},
			{"36-3-16", "P"},
			{"36-3-17", "Q"},
			{"36-3-18", "B"},
			{"36-3-19", "E"},
			{"36-3-20", "E"},
			{"36-3-21", "H"},
			{"36-3-22", "I"},
			{"36-3-23", "J"},
			{"36-3-24", "K"},
			{"36-3-25", "L"},
			{"36-3-26", "O"},
			{"36-3-27", "Q"},
			{"36-4-1", "A"},
			{"36-4-2", "B"},
			{"36-4-3", "C"},
			{"36-4-4", "D"},
			{"36-4-5", "E"},
			{"36-4-6", "F"},
			{"36-4-7", "G"},
			{"36-4-8", "H"},
			{"36-4-9", "I"},
			{"36-4-10", "J"},
			{"36-4-11", "K"},
			{"36-4-12", "L"},
			{"36-4-13", "M"},
			{"36-4-14", "N"},
			{"36-4-15", "O"},
			{"36-4-16", "P"},
			{"36-4-17", "Q"},
			{"36-4-18", "R"},
			{"36-4-19", "S"},
			{"36-4-20", "T"},
			{"36-4-21", "U"},
			{"36-4-22", "V"},
			{"36-4-23", "G"},
			{"36-4-24", "H"},
			{"36-4-25", "H"},
			{"36-4-26", "H"},
			{"36-4-27", "J"},
			{"36-4-28", "R"},
			{"36-4-29", "S"},
			{"36-4-30", "S"},
			{"36-5-1", "A"},
			{"36-5-2", "B"},
			{"36-5-3", "C"},
			{"36-5-4", "D"},
			{"36-5-5", "E"},
			{"36-5-6", "F"},
			{"36-5-7", "G"},
			{"36-5-8", "H"},
			{"36-5-9", "I"},
			{"36-5-10", "J"},
			{"36-5-11", "K"},
			{"36-5-12", "L"},
			{"36-5-13", "M"},
			{"36-5-14", "N"},
			{"36-5-15", "O"},
			{"36-5-16", "P"},
			{"36-5-17", "Q"},
			{"36-5-18", "R"},
			{"36-5-19", "S"},
			{"36-5-20", "T"},
			{"36-5-21", "U"},
			{"36-5-22", "G"},
			{"36-5-23", "K"},
			{"36-5-24", "N"},
			{"36-5-25", "O"},
			{"36-5-26", "U"},
			{"36-5-27", "I"},
			{"36-5-28", "K"},
			{"36-5-29", "M"},

			{"37-1-1", "A"},
			{"37-1-2", "B"},
			{"37-1-3", "C"},
			{"37-1-4", "D"},
			{"37-1-5", "E"},
			{"37-1-6", "F"},
			{"37-1-7", "G"},
			{"37-1-8", "H"},
			{"37-1-9", "I"},
			{"37-1-10", "J"},
			{"37-1-11", "K"},
			{"37-1-12", "B"},
			{"37-1-13", "B"},
			{"37-1-14", "L"},
			{"37-1-15", "M"},
			{"37-1-16", "D"},
			{"37-1-17", "N"},
			{"37-2-1", "A"},
			{"37-2-2", "B"},
			{"37-2-3", "C"},
			{"37-2-4", "D"},
			{"37-2-5", "E"},
			{"37-2-6", "F"},
			{"37-2-7", "G"},
			{"37-2-8", "H"},
			{"37-2-9", "I"},
			{"37-2-10", "J"},
			{"37-2-11", "K"},
			{"37-2-12", "L"},
			{"37-2-13", "M"},
			{"37-2-14", "E"},
			{"37-2-15", "F"},
			{"37-2-16", "G"},
			{"37-2-17", "H"},
			{"37-2-18", "I"},
			{"37-2-19", "J"},
			{"37-2-20", "J"},
			{"37-2-21", "K"},
			{"37-3-1", "A"},
			{"37-3-2", "B"},
			{"37-3-3", "C"},
			{"37-3-4", "D"},
			{"37-3-5", "E"},
			{"37-3-6", "F"},
			{"37-3-7", "G"},
			{"37-3-8", "H"},
			{"37-3-9", "I"},
			{"37-3-10", "J"},
			{"37-3-11", "K"},
			{"37-3-12", "L"},
			{"37-3-13", "M"},
			{"37-3-14", "N"},
			{"37-3-15", "O"},
			{"37-3-16", "P"},
			{"37-3-17", "Q"},
			{"37-3-18", "R"},
			{"37-3-19", "U"},
			{"37-3-20", "D"},
			{"37-3-21", "D"},
			{"37-3-22", "N"},
			{"37-3-23", "Q"},
			{"37-3-24", "U"},
			{"37-3-25", "S"},
			{"37-3-26", "T"},
			{"37-3-27", "V"},
			{"37-3-28", "W"},
			{"37-3-29", "X"},
			{"37-3-30", "J"},
			{"37-3-31", "L"},
			{"37-3-32", "L"},
		};
	}
}
