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
    public partial class Ranking_form : Form
    {
        public Ranking_form()
        {
            InitializeComponent();
        }
        public Ranking_form(string tekst)
        {
            InitializeComponent();
            ranking_rtb.Text = tekst;
        }
    }
}
