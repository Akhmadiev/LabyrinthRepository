namespace WindowsFormsApplication1.Enums
{
    public enum MapObject
    {
        WALL = 1,
        EXIT = 2
    }

    public static class MapObjects
    {
        public static string mapObject(MapObject mapObject)
        {
            switch (mapObject)
            {
                case MapObject.WALL:
                    return "WALL";

                case MapObject.EXIT:
                    return "EXIT";

                default:
                    return "";
            }
        }
    }
}
