using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class GameData
    {
        public string name { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public MapSize mapSize { get; set; }

        public PlayerCoords playerCoords { get; set; }

        public VisibleObjects visibleObjects { get; set; }

        public PlayerList playerList { get; set; }

        public VisiblePlayers visiblePlayers { get; set; }

        private const int size = 40;

        /// <summary>
        /// движение игрока
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public string Move(KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (int) Keys.Down:
                    return Enums.Direction.direction(Enums.Directions.East);

                case (int) Keys.Up:
                    return Enums.Direction.direction(Enums.Directions.West);

                case (int) Keys.Right:
                    return Enums.Direction.direction(Enums.Directions.South);

                case (int) Keys.Left:
                    return Enums.Direction.direction(Enums.Directions.North);

                default:
                    Errors.AppendError("Неопознанная ошибка");
                    return null;
            }
        }

        public List<BaseCommand> Send()
        {
            if (visibleObjects != null)
            {
                return new List<BaseCommand>() { playerCoords, visiblePlayers, visibleObjects };
            }
            return null;
        }

        /// <summary>
        /// прорисовка карты и объектов
        /// </summary>
        /// <param name="g"></param>
        //public void Draw(Graphics g)
        //{
        //    int x = playerCoords.row;
        //    int y = playerCoords.col;
        //    foreach (var map_object in visibleObjects.map_objects)
        //    {
        //        if (map_object.type == Enums.MapObjects.mapObject(Enums.MapObject.WALL))
        //        {

        //            g.DrawImage(new Bitmap("wall.jpg"),
        //                map_object.row*size + width/2 - x*size - size/2,
        //                map_object.col*size + height/2 - y*size - size/2,
        //                size, size);
        //        }
        //        if (map_object.type == Enums.MapObjects.mapObject(Enums.MapObject.EXIT))
        //        {
        //            g.DrawLine(new Pen(Color.Red, 2),
        //                map_object.row*size + width/2 - x*size - size/2,
        //                map_object.col*size + height/2 - y*size - size/2,
        //                map_object.row*size + width/2 - x*size - size/2 + size,
        //                map_object.col*size + height/2 - y*size - size/2 + size);

        //            g.DrawLine(new Pen(Color.Red, 2),
        //                map_object.row*size + width/2 - x*size - size/2 + size,
        //                map_object.col*size + height/2 - y*size - size/2,
        //                map_object.row*size + width/2 - x*size - size/2,
        //                map_object.col*size + height/2 - y*size - size/2 + size);
        //        }
        //    }

        //    foreach (var player in visiblePlayers.players)
        //    {
        //        g.DrawString(player.name, new Font(FontFamily.GenericMonospace, size/2),
        //            new SolidBrush(Helping.playerColor(player.name, playerList)),
        //            player.row*size + width/2 - x*size - size/2 + size/2 - player.name.Length/2*size/2,
        //            player.col*size + height/2 - y*size - size/2 - size);

        //        g.DrawImage(new Bitmap("war.jpg"),
        //            player.row*size + width/2 - x*size - size/2,
        //            player.col*size + height/2 - y*size - size/2,
        //            size, size);
        //    }

        //    g.DrawImage(new Bitmap("player.png"),
        //        width/2 - size/2,
        //        height/2 - size/2,
        //        size, size);

        //    g.DrawString(name, new Font(FontFamily.GenericMonospace, size/2),
        //        new SolidBrush(Helping.playerColor(name, playerList)),
        //        width/2 - size/2 + size/2 - name.Length/2*size/2,
        //        height/2 - size/2 - size);
        //}
    }
}