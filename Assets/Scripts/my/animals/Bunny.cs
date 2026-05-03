using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Bunny: Animal
	{
		public static Bunny Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {LandBased.Create("Hopping")}
			};
		}
        // POLYMORPHISM
        public override string makeNoise()
		{
			return "Bunny munches on a carrot.";
        }

    }
}