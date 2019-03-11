using SaperGame.FilesGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame
{
    public partial class SettingsBoard : Form
    {
        Saper saper;
        Board board;
        public SettingsBoard()
        {
            InitializeComponent();
        }
        public SettingsBoard( Saper saper, Board board)
        {
           InitializeComponent();
           this.board = board;
            this.saper = saper;
        }

        private void play_b_Click(object sender, EventArgs e)
        {

            int diff = 0;
            if (hard_rb.Checked)
            {
                diff = 3;
            }
            else if (normal_rb.Checked)
            {
                diff = 2;
            }
            else if(esey_rb.Checked)
            {
                diff = 1;
            }
            else
            {
                MessageBox.Show("Nie został wybrany poziom trudności", "Poziom trudnosci", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            board.Difficul = diff;

            int size = 0;
            if (big_rb.Checked)
            {
                size = 3;
            }
            else if (medium_rb.Checked)
            {
                size = 2;
            }
            else if (small_rb.Checked)
            {
                size = 1;
            }
            else
            {
                MessageBox.Show("Nie została wybrana wielkość planszy", "Wielkość planszy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            board.Size = size;
   

            if (size>0&&diff>0)
            {
                this.Visible = false;
                this.Close();
                CreateBoard createBoard = new CreateBoard(board);
                board.WindowGame= CreateWindow.Create(board);
                saper.Visible = true;
                saper.StartGame();
            }

        }

     
    }
}
