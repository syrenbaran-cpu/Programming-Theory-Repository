namespace Assets.Scripts.my.animals
{
    using Assets.Scripts.my.terrain;
    using Assets.Scripts.my.movement;
    using System.Collections.Generic;
    using System;
    using Unity.Mathematics;

    public abstract class Animal{
        // ENCAPSULATION
        public string name { get; protected set; }  
        protected List<Locomotion> locomotionTypes;
        private TerrainType currentTerrain;
        // ENCAPSULATION
        public TerrainType CurrentTerrain
        {
            get => currentTerrain;
            set
            {
                if (locomotionTypes != null)
                {
                    if (value.isPassable(locomotionTypes).Count > 0) {
                        currentTerrain = value;
                        return;
                    }
                }
                throw new System.Exception("Animal cannot move to this terrain");
            }
        }
        // INHERITANCE
        public Locomotion getLocomotionForTerrain(TerrainType terrain)
        {
            if (locomotionTypes != null)
            {
                List<Locomotion> passableLocomotions = terrain.isPassable(locomotionTypes);
                if (passableLocomotions.Count > 0)
                {
                    int index = UnityEngine.Random.Range(0, passableLocomotions.Count);
                    return passableLocomotions[index];
                }
            }
            return null;
        }
        // INHERITANCE
        public Locomotion getLocomotionForCurrentTerrain()
        {
            return getLocomotionForTerrain(currentTerrain);
        }
        // POLYMORPHISM
        public abstract string makeNoise();
        // INHERITANCE
        public bool CanMoveTo(TerrainType terrain)
        {
            return getLocomotionForTerrain(terrain) != null;
        }
    }
}