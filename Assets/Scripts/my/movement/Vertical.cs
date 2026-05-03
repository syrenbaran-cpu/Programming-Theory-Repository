using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.terrain;

namespace Assets.Scripts.my.movement
{
	public class Vertical: Locomotion
	{
		public static Vertical Create(string type)
		{
			return new()
			{
				type = type,
				availableTerrain = new List<TerrainEnum>()
				{
					TerrainEnum.Elevated
				}
			};
        }

    }
}