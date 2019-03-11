using SaperGame.FilesGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.Serializacja.Binarna
{
   public class SerialBin
    {

        protected List<Field> FieldList { get; set; } = new List<Field>();

        protected string Sciezka { get; private set  ; }
        protected string Folder { get; private set; } = Environment.CurrentDirectory + "\\Save";
        private void NewSciezka(string nick)
        {
            Sciezka = Environment.CurrentDirectory + "\\Save\\" + nick + ".xml";
        }
        public SerialBin(Player player)
        {
            NewSciezka(player.Nick);
        }


    }
}
