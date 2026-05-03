namespace Assets.Scripts.my.movement{
    using Assets.Scripts.my.terrain;
    using System;
    using System.Collections.Generic;

    public class Locomotion{
        // ENCAPSULATION
        public string type { get; protected set; }
        protected List<TerrainEnum> availableTerrain;
        // INHERITANCE
        public Boolean canMoveTo(TerrainType terrain)
        {
            return availableTerrain != null && availableTerrain.Contains(terrain.type);
        }

    }
}