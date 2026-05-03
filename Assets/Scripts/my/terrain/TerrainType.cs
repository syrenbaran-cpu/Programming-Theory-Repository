namespace Assets.Scripts.my.terrain
{
    using Assets.Scripts.my.movement;
    using Assets.Scripts.my.terrain;
    using System;
    using System.Collections.Generic;

    public class TerrainType
    {
        //ENCAPSULATION
        public string name { get; protected set; }
        //ENCAPSULATION
        public string description { get; protected set; } = string.Empty;

        // ENCAPSULATION
        public TerrainEnum type { get; protected set; }
        // INHERITANCE
        public List<Locomotion> isPassable(List<Locomotion> locomotions)
        {
            List<Locomotion> passableLocomotions = new List<Locomotion>();
            if (locomotions != null)
            {
                for (int i = 0; i < locomotions.Count; i++)
                {
                    if (locomotions[i].canMoveTo(this))
                    {
                        passableLocomotions.Add(locomotions[i]);
                    }
                }
            }
            return passableLocomotions;
        }

    }
    // ABSTRACTION
    public enum TerrainEnum { Land, Water, Air, Elevated }
}