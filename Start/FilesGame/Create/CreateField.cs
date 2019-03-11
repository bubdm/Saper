using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.FilesGame
{
    class CreateField
    {
        Saper saper;
        Game game;
        public CreateField(Saper saper, Game game)
        {
            this.saper = saper;
            this.game = game;
        }
        public void Create(int x, int y, int gridX, int gridY)
        {
                game.Board.GameBoard.Btn_grid[x, y] = createButton(gridX , gridY , x, y);
                game.Board.GameBoard.Lbl_grid[x, y]= createLables(gridX, gridY);
        }

        private Button createButton(int x, int y, int gridX, int gridY)
        {
            Button bttn = new Button();

            bttn.Text = "";
            bttn.Name = gridX.ToString() + " " + gridY.ToString();
            bttn.Size = new System.Drawing.Size(24, 24);
            bttn.Location = new System.Drawing.Point(x, y);
            saper.Controls.AddRange(new System.Windows.Forms.Control[] { bttn, });
            //  bttn.Click += new System.EventHandler(bttnOnclick);
            saper.DodajZdarzenie(bttn);
            //bttn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bttnOnRightClick);

            return bttn;
        }

        private Label createLables(int x, int y)
        {
            Label lbl = new Label();
            lbl.Name = x.ToString() + " " + y.ToString();
            lbl.Text = "0";
            lbl.Size = new System.Drawing.Size(24, 24);
            lbl.Font = new Font("Microsoft Sans Serif", 15.75f, lbl.Font.Style, lbl.Font.Unit);
            lbl.Location = new System.Drawing.Point(x, y);
            saper.Controls.AddRange(new System.Windows.Forms.Control[] { lbl, });
            return lbl;
        }

    }
}
