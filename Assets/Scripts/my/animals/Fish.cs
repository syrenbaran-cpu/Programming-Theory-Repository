using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.my.movement;

namespace Assets.Scripts.my.animals
{
	public class Fish: Animal
	{
		public static Fish Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion> {Aquatic.Create("Swimming")}
			};
		}
		public override string makeNoise()
		{
			return "Fish blubs.";
        }

    }
}