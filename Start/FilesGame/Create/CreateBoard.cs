using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.FilesGame
{
    public class CreateBoard
    {
        public CreateBoard(Board board)
        {
         
            board.MineCount = Difficul(board.Difficul, board.Size);
            int[] rozmiar = Sizeboard(board.Size);
            board.Heigh = rozmiar[1];
            board.Width = rozmiar[0];
          
            board.FieldCountWithOutMine = FieldCountWithOutMine(board.Heigh, board.Width, board.MineCount);


        }

    


        private int[] Sizeboard(int size)
        {
            int[] rozmiar = new int[2];
            switch (size)
            {
                case 1:

                    rozmiar[0] = 9;
                    rozmiar[1] = 9;

                    break;
                case 2:

                    rozmiar[0] = 16;
                    rozmiar[1] = 16;
                    break;
                case 3:

                    rozmiar[0] = 30;
                    rozmiar[1] = 16;
                    break;
                default:
            
                    break;
            }
            return rozmiar;

        }
        private int Difficul(int diff, int size)
        {
            int diffsize = 0; ;

            switch (size)
            {
                case 1:
                    diffsize = 1;


                    break;
                case 2:
                    diffsize = 3;

                    break;
                case 3:
                    diffsize = 5;

                    break;
                default:
              
                    break;
            }

            int minteCount = 0;
            switch (diff)
            {
                case 1:
                    minteCount = 10;


                    break;
                case 2:
                    minteCount = 20;

                    break;
                case 3:
                    minteCount = 30;

                    break;
                default:
                 
                    break;
            }
            return minteCount * diffsize;



        }
        private int FieldCountWithOutMine( int heigh, int width, int mineCount)
        {
            return (heigh * width) - mineCount;
        }
    }
}
