using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Monkey: Animal
	{
		public static Monkey Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {LandBased.Create("Walking"), Vertical.Create("Climbing")}
			};
        }

        public override string makeNoise()
        {
            return "The monkey chatters.";
        }
    }
}