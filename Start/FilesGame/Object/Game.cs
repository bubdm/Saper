using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.FilesGame
{
    public class Game
    {
        public Player Player { get; private set; }
        public Board Board { get; private set; }

        public int ShowedField { get; set; }
        public int Time { get; private set; }



        public Game(Player player )
        {
            Player = player;
        }

        public Game(Player player, Board board)
        {
            Player = player;
            Board = board;
        }


        public void TimeClean()
        {
            Time = 0;
        }

        public void TimePlus(int plus)
        {
            Time += plus;
        }
        public void TimeSet(int time)
        {
            Time = time;
        }

    }
}
