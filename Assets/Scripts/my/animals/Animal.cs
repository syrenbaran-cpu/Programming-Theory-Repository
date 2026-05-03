namespace Assets.Scripts.my.animals
{
    using Assets.Scripts.my.terrain;
    using Assets.Scripts.my.movement;
    using System.Collections.Generic;
    using System;
    using Unity.Mathematics;

    public abstract class Animal{
        public string name { get; protected set; }  
        protected List<Locomotion> locomotionTypes;
        private TerrainType currentTerrain;
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
        public Locomotion getLocomotionForCurrentTerrain()
        {
            return getLocomotionForTerrain(currentTerrain);
        }
        public abstract string makeNoise();
        public bool CanMoveTo(TerrainType terrain)
        {
            return getLocomotionForTerrain(terrain) != null;
        }
    }
}