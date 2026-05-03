using UnityEngine;
using System.Collections;

namespace Assets.Scripts.my.terrain
{
	public class Sky : TerrainType
	{
		public static Sky Create(string name, string description)
		{
			Sky retval = new Sky();
			retval.name = name;
			retval.description = description;
			retval.type = TerrainEnum.Air;
			return retval;
		}
	}
}