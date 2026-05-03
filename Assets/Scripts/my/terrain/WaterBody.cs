using UnityEngine;
using System.Collections;

namespace Assets.Scripts.my.terrain
{
	public class WaterBody: TerrainType
	{
		public static WaterBody Create(string name, string description)
		{
			return new()
			{
				name = name,
				description = description,
				type = TerrainEnum.Water
			};
        }
    }
}