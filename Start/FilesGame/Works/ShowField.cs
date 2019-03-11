using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.FilesGame
{
   public class ShowField
    {

        Game game;
        public ShowField(int x, int y, Game game)
        {
            this.game = game;
            Show( x, y);
        }

        private void Show(int x, int y)
        {
        
            if (!game.Board.GameBoard.Btn_grid[x, y].Visible)
            {
                return;
            }

            {
                game.ShowedField++;
                game.Board.GameBoard.Btn_grid[x, y].Visible = false;
                for (int xx = -1; xx < 2; xx++)
                {
                    for (int yy = -1; yy < 2; yy++)
                    {
                        if (x + xx >= 0 && y + yy >= 0 && x + xx < game.Board.Width && y + yy < game.Board.Heigh)
                        {

                            {
                                game.Board.GameBoard.Btn_grid[x, y].Visible = false;

                                if (game.Board.GameBoard.Grid[x, y] == 0)
                                {

                                    Show(x + xx, y + yy);
                                }
                            }

                        }
                    }
                }
            }
        }
        }
}
