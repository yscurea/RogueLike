﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Creature
{
	[DefaultExecutionOrder(0)]
	public class CreatureDirector : MonoBehaviour
	{
		[SerializeField] GameObject dungeonDirector;
		[SerializeField] CreaturesObject creatureObject;
		void Start()
		{
			creatureObject.InstantiateCreatures();
		}
	}
}