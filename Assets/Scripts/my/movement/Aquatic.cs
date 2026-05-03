using UnityEngine;
using System.Collections;
using Assets.Scripts.my.terrain;
using System.Collections.Generic;

namespace Assets.Scripts.my.movement
{
	public class Aquatic: Locomotion
	{
		public static Aquatic Create(string type)
		{
			return new()
			{
				type = type,
				availableTerrain = new List<TerrainEnum>()
				{
					TerrainEnum.Water
				}
			};
        }
    }
}