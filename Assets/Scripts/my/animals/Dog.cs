using Assets.Scripts.my.movement;
using System.Collections.Generic;

namespace Assets.Scripts.my.animals
{
	

    public class Dog : Animal
	{
		public static Dog Create(string name)
		{
			return new()
			{
				name = name,
				locomotionTypes = new List<Locomotion>(){
					LandBased.Create("Walking"),
					LandBased.Create("Running"),
					Aquatic.Create("Swimming")
				}
			};
		}
        // POLYMORPHISM
        public override string makeNoise()
        {
            return "Dog barks.";
        }
    }
}