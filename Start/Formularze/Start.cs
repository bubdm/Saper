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
    public partial class Start : Form
    {

        public Start()
        {
            InitializeComponent();

        }

        private void next_b_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nick_tb.Text))
            {
                MessageBox.Show("Nick nie został wpisany.", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Player player = new Player(nick_tb.Text);
                Saper board = new Saper(player);
           
                this.Visible = false;
            }
        }
    }
}
