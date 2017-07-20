namespace WindowsFormsApplication1
{
    public class MapObject
    {
        public string type { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public MapObject() { }

        public MapObject(string type, int row, int col)
        {
            this.type = type;
            this.row = row;
            this.col = col;
        }
    }
}
