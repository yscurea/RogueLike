﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Dungeon
{



	[System.Serializable]
	public class DungeonInstantiation
	{
		[SerializeField]
		private GameObject wall;

		[SerializeField]
		private GameObject floor;


		private void Instantiate(TerrainType[,] dungeonInfo)
		{

			for(int zi = 0; zi < dungeonInfo.GetLength(0); zi++)
			{
				for(int xi = 0; xi < dungeonInfo.GetLength(1); xi++)
				{
					GameObject tmp;
					switch (dungeonInfo[zi, xi])
					{
						case TerrainType.Room:
						case TerrainType.Way:


							break;
						case TerrainType.Wall:
							break;
						default:
							break;
					}
				}

			}
		}
	}
}