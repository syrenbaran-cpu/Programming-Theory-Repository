using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Turtle: Animal
	{
		public static Turtle Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {LandBased.Create("Crawling"), Aquatic.Create("Swimming")}
			};
        }

        public override string makeNoise()
        {
            return "The turtle makes a low grunting sound.";
        }
    }
}