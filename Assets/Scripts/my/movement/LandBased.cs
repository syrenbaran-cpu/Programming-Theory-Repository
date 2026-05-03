using Assets.Scripts.my.terrain;
using System.Collections.Generic;

namespace Assets.Scripts.my.movement{

    public class LandBased : Locomotion
    {
        public static LandBased Create(string type)
        {
            return new()
            {
                type = type,
                availableTerrain = new List<TerrainEnum>()
                {
                    TerrainEnum.Land
                }
            };
        }
    }
}