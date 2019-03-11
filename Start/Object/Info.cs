using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.Obiekty
{
    class Info
    {
        public Info()
        {
            string tresc = "Program Saper \n";
            MessageBox.Show(tresc, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
