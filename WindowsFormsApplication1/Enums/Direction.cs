namespace WindowsFormsApplication1.Enums
{
    public enum Directions
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }

    public static class Direction
    {
        public static string direction(Directions direction)
        {
            switch (direction)
            {
                case Directions.North:
                    return "N";                    

                case Directions.South:
                    return "S";                    

                case Directions.East:
                    return "E";                    

                case Directions.West:
                    return "W";

                default:
                    return "";
            }
        }
    }
}
