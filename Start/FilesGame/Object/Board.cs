using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.FilesGame
{
    public class Board
    {
        public readonly int startX;
        public readonly int startY;

        private int difficul;

        private int size;

        public int Heigh { get; set; }
        public int Width { get; set; }
        public int MineCount { get; set; }
        public int FieldCountWithOutMine { get; set; }

        public GameBoard GameBoard { get; set; }

        public WindowGame WindowGame { get; set; }
        public int Difficul
        {
            get { return difficul; }

            set
            {
                if (0 < value && value < 4)
                {
                    difficul = value;
                }
                else difficul = 0;
            }
        }

        public int Size
        {
            get { return size; }

            set
            {
                if (0 < value && value < 4)
                {
                    size = value;
                }
                else size = 0;
            }
        }




        public Board(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;
        }
        public void CleanBoard()
        {
            difficul = 0;
            size = 0;
            Heigh = 0;
            Width = 0;
            MineCount = 0;
            FieldCountWithOutMine = 0;
            WindowGame.CLeanWindow();
        }
    }
}
