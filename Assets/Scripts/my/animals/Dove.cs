using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Dove: Animal
	{
		public static Dove Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {Aerial.Create("Flying"), LandBased.Create("Walking")}
			};
        }
        // POLYMORPHISM
        public override string makeNoise()
        {
            return "Dove coo-coos.";
        }
    }
}