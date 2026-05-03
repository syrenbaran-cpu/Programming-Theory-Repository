using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Duck: Animal
	{
		public static Duck Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {LandBased.Create("Waddling"), Aerial.Create("Flying"), Aquatic.Create("Swimming")}
			};
        }

        public override string makeNoise()
        {
            return "The duck quacks.";
        }
    }
}