namespace Assets.Scripts.my.terrain
{
    public class Grassland : TerrainType
    {

        public static Grassland Create(string name)
        {
            Grassland retval = new Grassland();
            retval.name = name;
            retval.type = TerrainEnum.Land;
            return retval;
        }
    }
} 
