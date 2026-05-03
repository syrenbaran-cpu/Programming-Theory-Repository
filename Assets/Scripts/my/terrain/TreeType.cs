using UnityEngine;
using System.Collections;

namespace Assets.Scripts.my.terrain
{
	public class TreeType: TerrainType
	{
		public static TreeType Create(string name, string description)
		{
			return new()
			{
				name = name,
				description = description,
				type = TerrainEnum.Elevated
			};
		}
	}
}