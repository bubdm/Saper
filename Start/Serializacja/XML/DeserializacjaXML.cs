using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SaperGame.Serializacja.XML
{
    class DeserializacjaXML:SerialXML
    {
        public DeserializacjaXML()
        {
           Read();
        }
        public List<Record> ShowList()
        {
            return record_List;
        }
        private void Read()
        {
          
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Record>));
                StreamReader streamReader = new StreamReader(Sciezka);
                record_List = (List<Record>)xmlSerializer.Deserialize(streamReader);
                streamReader.Close();
                // MessageBox.Show("Wczytaj", "Pomyślnie udało się wczytać stn gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception  )
            {

             //   MessageBox.Show("Błąd. : "+ e.Message, "Wystąpienie jakiegoś błedu w Otwórz ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
    }
}
