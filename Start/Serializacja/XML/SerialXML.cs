using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.Serializacja.XML
{
   public abstract class SerialXML
    {
        protected List<Record> record_List = new List<Record>();

        protected string  Sciezka = Environment.CurrentDirectory + "\\RecordsFile\\Records.xml";
        protected string pathToDirectory = Environment.CurrentDirectory + "\\RecordsFile";
  
    }
}
