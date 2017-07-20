namespace WindowsFormsApplication1
{
    public class Player
    {
        public string name { get; set; }

        public int color { get; set; }

        public Player() { }

        public Player(string name, int color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
