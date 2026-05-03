namespace Assets.Scripts.my.terrain
{
    public class Grassland : TerrainType
    {

        public static Grassland Create(string name, string description)
        {
            Grassland retval = new Grassland();
            retval.name = name;
            retval.description = description;
            retval.type = TerrainEnum.Land;
            return retval;
        }
    }
} 
