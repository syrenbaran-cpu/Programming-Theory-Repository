using UnityEngine;
using System.Collections;
using Assets.Scripts.my.terrain;
using System.Collections.Generic;

namespace Assets.Scripts.my.movement
{
	public class Aerial: Locomotion
	{
		public static Aerial Create(string type)
		{
			return new()
			{
				type = type,
				availableTerrain = new List<TerrainEnum>()
				{
					TerrainEnum.Air,
					TerrainEnum.Water,
					TerrainEnum.Land,
					TerrainEnum.Elevated						
                }
			};
        }
	}
}