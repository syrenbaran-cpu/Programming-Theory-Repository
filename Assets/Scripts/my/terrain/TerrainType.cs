namespace Assets.Scripts.my.terrain
{
    using Assets.Scripts.my.terrain;
    public class TerrainType
    {

        public string name { get; protected set; }

        

        public TerrainEnum type { get; protected set; }

    }
    public enum TerrainEnum { Land, Water, Air, Elevated }
}