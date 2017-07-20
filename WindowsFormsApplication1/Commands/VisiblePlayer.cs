namespace WindowsFormsApplication1
{
    public class VisiblePlayer
    {
        public string name { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public VisiblePlayer() { }

        public VisiblePlayer(string name, int row, int col)
        {
            this.name = name;
            this.row = row;
            this.col = col;
        }
    }
}
