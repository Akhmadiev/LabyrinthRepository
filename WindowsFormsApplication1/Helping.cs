using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal static class Helping
    {
        /// <summary>
        /// Вывод имен в форме
        /// </summary>
        /// <param name="playerList"></param>
        /// <param name="playersBox"></param>
        public static void PlayerList(PlayerList playerList, RichTextBox playersBox)
        {
            playersBox.Clear();
            playersBox.SelectionAlignment = HorizontalAlignment.Center;
            foreach (var player in playerList.players)
            {                
                //playersBox.SelectionColor = Color.FromName(String.Format("{0}", player.color));
                playersBox.SelectionColor = Color.FromArgb(player.color);
                playersBox.AppendText(player.name + "\n");                        
            }
        }

        /// <summary>
        /// вывод таймера в форме
        /// </summary>
        /// <param name="timeDecimal"></param>
        /// <returns></returns>
        public static string TimeLeft(decimal timeDecimal)
        {                       
            double time = Convert.ToInt32(timeDecimal);
            time /= 10000;
            time = Math.Round(time)*10;            
            return Math.Floor(time/60).ToString() + ":" +
                   (time%60 == 0 ? "00" : (time - Math.Floor(time/60)*60).ToString());
        }

        /// <summary>
        /// получение цвета игрока для прорисовки
        /// </summary>
        /// <param name="name"></param>
        /// <param name="players"></param>
        /// <returns></returns>
        public static Color playerColor(string name, PlayerList players)
        {
            foreach (var player in players.players)
            {
                if (player.name == name)
                {
                    //return Color.FromName(String.Format("{0}", player.color));
                    return Color.FromArgb(player.color);
                }
            }
            return Color.Black;
        }
    }
}