using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame
{
    
    class Help
    {
        static string sciezka = Environment.CurrentDirectory + "\\Pomoc.pdf";

        public Help()
        {
            OtworzPDF();
        }

        private void OtworzPDF()
        {
            try
            {
                System.Diagnostics.Process.Start(sciezka);
            }
            catch (Exception )
            {
                MessageBox.Show("Wystąpienie jakiegoś błedu przy otwarciu pliku ", "Błąd.",  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
