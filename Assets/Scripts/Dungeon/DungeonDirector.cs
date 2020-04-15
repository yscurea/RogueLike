﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Dungeon
{
	public class DungeonDirector : MonoBehaviour
	{
		public static float sqareSize = 1.0f;

		private static int hierarchy = 0;

		[SerializeField]
		DungeonInstantiation dungeonInstantiation;
		[SerializeField]
		DungeonGenerator dungeonGenerator;


		void Start()
		{
			InitDungeon();
		}

		private void InitDungeon()
		{
			int dungeonZ, dungeonX;
			(dungeonZ, dungeonX) = dungeonGenerator.GetDungeonSize();
			dungeonGenerator = new Dungeon.DungeonGenerator(dungeonZ, dungeonX);
			dungeonInstantiation.DungeonInstantiate(dungeonGenerator.GenerateMap(),this.gameObject);

			Creature.CreaturePosition.InitCreaturesPosition(dungeonZ, dungeonX);
			item.ItemPosition.InitItemsPosition(dungeonZ, dungeonX);

			//playerの生成
			//敵を適量生成
			//アイテムの生成
		}




	}
}