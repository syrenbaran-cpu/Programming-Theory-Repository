using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Cat: Animal
	{
		public static Cat Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {LandBased.Create("Running"), Vertical.Create("Climbing")}
			};
        }
        // POLYMORPHISM
        public override string makeNoise()
        {
            return "Cat purrs.";
        }
    }
}