using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.FilesGame
{
    class CreateWindow
    {
        public static WindowGame Create(Board board)
        {
            int windowHeigh = WindowHeigh(board.startY, board.Heigh);
            int windowWidth = WindowWidth(board.startX, board.Width);
            WindowGame result = new WindowGame(windowHeigh, windowWidth);
            return result;


        }



        private static int WindowHeigh(int startY, int heigh)
        {
            return (startY * 2) + (heigh * 24);
        }
        private static int WindowWidth(int startX, int width)
        {
            return startX * 2 + (width + 1) * 24 - 5;
        }
    }
}
