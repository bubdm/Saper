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
  public  class SerializacjaXML : SerialXML
    {
        public SerializacjaXML(List<Record> recordList)
        {
            record_List = recordList;
            Write();
        }
        private void Write()
        {
            try
            {
                CheckFolder(pathToDirectory);
                if (!File.Exists(Sciezka))
                {
                    using (FileStream fs = new FileStream(Sciezka, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {}
                }
      
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Record>));
                StreamWriter streamWriter = new StreamWriter(Sciezka, false);
                xmlSerializer.Serialize(streamWriter, record_List);
                streamWriter.Close();
              //  MessageBox.Show("Powinno się udać zapisać .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("nie udało sie zapisać .", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CheckFolder(string PathToDirectory)
        {
            if (Directory.Exists(PathToDirectory) == false)
            {
                Directory.CreateDirectory(PathToDirectory);
           //     MessageBox.Show("\nFolder: " + PathToDirectory + " został utworzony.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
          


}
}
