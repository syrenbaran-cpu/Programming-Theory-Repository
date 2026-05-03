namespace Assets.Scripts.my.terrain
{
    using Assets.Scripts.my.movement;
    using Assets.Scripts.my.terrain;
    using System;
    using System.Collections.Generic;

    public class TerrainType
    {

        public string name { get; protected set; }
        public string description { get; protected set; } = string.Empty;


        public TerrainEnum type { get; protected set; }

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
    public enum TerrainEnum { Land, Water, Air, Elevated }
}