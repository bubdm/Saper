using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.FilesGame
{
  public  class FillBoard
    {
        Game game;
        Saper saper;
        CreateField createField;
        public FillBoard(Game game, Saper saper)
        {
            this.createField = new CreateField(saper, game);
            this.game = game;
            this.saper = saper;
            Fill();
        }
        private int[,]    Gridnew    ;
        private Button[,] Btn_gridnew;
        private Label[,]  Lbl_gridnew;
        private void Fill()
        {
            Gridnew = new int[game.Board.Width, game.Board.Heigh];
            Btn_gridnew = new Button[game.Board.Width, game.Board.Heigh];
            Lbl_gridnew = new Label[game.Board.Width, game.Board.Heigh];


            game.Board.GameBoard = new GameBoard(Gridnew, Btn_gridnew, Lbl_gridnew);

          





        Random rnd1 = new Random();






            for (int x = 0; x < game.Board.Width; x++)
            {
                for (int y = 0; y < game.Board.Heigh; y++)
                {
                    game.Board.GameBoard.Grid[x, y] = 0;

                    createField.Create( x, y, game.Board.startX + 24 * (x + 0), game.Board.startY + 24 * (y + 0));
    
                }
            }

            int currMineCount = game.Board.MineCount;

            while (currMineCount > 0)
            {
                int mineX = rnd1.Next(game.Board.Width);
                int mineY = rnd1.Next(game.Board.Heigh);

                if (game.Board.GameBoard.Grid[mineX, mineY] == 0)
                {
                    game.Board.GameBoard.Lbl_grid[mineX, mineY].Text = "*";
                    game.Board.GameBoard.Lbl_grid[mineX, mineY].Font = new Font("Microsoft Sans Serif", 30.75f, game.Board.GameBoard.Lbl_grid[mineX, mineY].Font.Style, game.Board.GameBoard.Lbl_grid[mineX, mineY].Font.Unit);
                    game.Board.GameBoard.Lbl_grid[mineX, mineY].Location = new System.Drawing.Point(game.Board.GameBoard.Lbl_grid[mineX, mineY].Location.X - 5, game.Board.GameBoard.Lbl_grid[mineX, mineY].Location.Y);
                    game.Board.GameBoard.Grid[mineX, mineY] = -1;
                    currMineCount--;
                }
            }


            for (int x = 0; x < game.Board.Width; x++)
            {
                for (int y = 0; y < game.Board.Heigh; y++)
                {

                    if (game.Board.GameBoard.Grid[x, y] != -1)
                    {

                        int numMines = 0;
                        for (int xx = -1; xx < 2; xx++)
                        {
                            for (int yy = -1; yy < 2; yy++)
                            {
                                if (x + xx >= 0 && y + yy >= 0 && x + xx < game.Board.Width && y + yy < game.Board.Heigh)
                                {
                                    if (game.Board.GameBoard.Grid[x + xx, y + yy] == -1)
                                    {
                                        numMines++;
                                    }
                                }


                            }
                        }
                        game.Board.GameBoard.Grid[x, y] = numMines;

                        if (numMines == 0)
                        {
                            game.Board.GameBoard.Lbl_grid[x, y].Text = " ";
                        }
                        else
                        {
                            game.Board.GameBoard.Lbl_grid[x, y].Text = numMines.ToString();
                        }


                    }
                }
            }

        }
    }
}
