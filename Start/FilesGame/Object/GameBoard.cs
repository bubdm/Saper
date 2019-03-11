using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.FilesGame
{
    public class GameBoard
    {

        public GameBoard(int[,] Grid, Button[,] Btn_grid, Label[,] Lbl_grid)
        {
            this.Grid = Grid;
            this.Lbl_grid = Lbl_grid;
            this.Btn_grid = Btn_grid;
        }                  

          public int[,] Grid     { get; set; }
          public Button[,] Btn_grid { get; set; }
          public Label[,] Lbl_grid { get; set; }
    

    }
}
