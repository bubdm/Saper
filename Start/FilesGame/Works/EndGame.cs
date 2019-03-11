using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.FilesGame
{
    class EndGame
    {
        Game game;

      
        public EndGame(Game game)
        {
         
            this.game = game;

            End();
        }

        private void End()
        {

            for (int xx = 0; xx < game.Board.Width; xx++)
            {
                for (int yy = 0; yy < game. Board.Heigh; yy++)
                {
                    if (game.Board.GameBoard.Grid[xx, yy] == -1)
                    {
                        game.Board.GameBoard.Btn_grid[xx, yy].Visible = false;
                    }
                }
            }
            MessageBox.Show("Przegrałeś w sapera już Ciebie tu nie ma.", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
