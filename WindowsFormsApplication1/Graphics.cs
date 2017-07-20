using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Graphics : Control
    {
        private static int size = 40;
        private List<BaseCommand> list;

        public Graphics()
        {
            list = new GameData().Send();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            VisibleObjects visibleObjects;
            VisiblePlayers visiblePlayers;
            PlayerCoords playerCoords;

            foreach (var val in list)
            {

            }



            int x = playerCoords.row;
            int y = playerCoords.col;
            foreach (var map_object in visibleObjects.map_objects)
            {
                if (map_object.type == Enums.MapObjects.mapObject(Enums.MapObject.WALL))
                {

                    g.DrawImage(new Bitmap("wall.jpg"),
                        map_object.row * size + width / 2 - x * size - size / 2,
                        map_object.col * size + height / 2 - y * size - size / 2,
                        size, size);
                }
                if (map_object.type == Enums.MapObjects.mapObject(Enums.MapObject.EXIT))
                {
                    g.DrawLine(new Pen(Color.Red, 2),
                        map_object.row * size + width / 2 - x * size - size / 2,
                        map_object.col * size + height / 2 - y * size - size / 2,
                        map_object.row * size + width / 2 - x * size - size / 2 + size,
                        map_object.col * size + height / 2 - y * size - size / 2 + size);

                    g.DrawLine(new Pen(Color.Red, 2),
                        map_object.row * size + width / 2 - x * size - size / 2 + size,
                        map_object.col * size + height / 2 - y * size - size / 2,
                        map_object.row * size + width / 2 - x * size - size / 2,
                        map_object.col * size + height / 2 - y * size - size / 2 + size);
                }
            }

            foreach (var player in visiblePlayers.players)
            {
                g.DrawString(player.name, new Font(FontFamily.GenericMonospace, size / 2),
                    new SolidBrush(Helping.playerColor(player.name, playerList)),
                    player.row * size + width / 2 - x * size - size / 2 + size / 2 - player.name.Length / 2 * size / 2,
                    player.col * size + height / 2 - y * size - size / 2 - size);

                g.DrawImage(new Bitmap("war.jpg"),
                    player.row * size + width / 2 - x * size - size / 2,
                    player.col * size + height / 2 - y * size - size / 2,
                    size, size);
            }

            g.DrawImage(new Bitmap("player.png"),
                width / 2 - size / 2,
                height / 2 - size / 2,
                size, size);

            g.DrawString(name, new Font(FontFamily.GenericMonospace, size / 2),
                new SolidBrush(Helping.playerColor(name, playerList)),
                width / 2 - size / 2 + size / 2 - name.Length / 2 * size / 2,
                height / 2 - size / 2 - size);
        }
    }
}
