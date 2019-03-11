using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.FilesGame
{
    class CleanGame
    {
        public CleanGame(Game game,Saper saper)
        {
            Remove(game,saper);
        }
        public void Remove(Game game, Saper saper)
        {
            
            if (game.Board.GameBoard.Btn_grid != null)
            {
                for (int x = 0; x < game.Board.GameBoard.Btn_grid.GetLength(0); x++)
                {
                    for (int y = 0; y < game.Board.GameBoard.Btn_grid.GetLength(1); y++)
                    {


                     

                        if (saper.Controls.Contains(game.Board.GameBoard.Btn_grid[x, y]))
                        {
                            saper.Controls.Remove(game.Board.GameBoard.Btn_grid[x, y]);
                        }

                        if (saper.Controls.Contains(game.Board.GameBoard.Lbl_grid[x, y]))
                        {
                            saper.Controls.Remove(game.Board.GameBoard.Lbl_grid[x, y]);
                        }


                    }
                }
            }

        }
    }
}
