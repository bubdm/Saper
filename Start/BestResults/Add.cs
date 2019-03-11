using SaperGame.Serializacja.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.BestResults
{
    class Add
    {
        public Add(FilesGame.Game game)
        {
            DeserializacjaXML deserializacjaXML = new DeserializacjaXML();
            SaveRecord(deserializacjaXML.ShowList(), game);


        }

            public void SaveRecord(List<Record> list, FilesGame.Game game)
            {
            
            Record record = new Record(game.Player.Nick,game.Board.Difficul,game.Board.Size,game.Time);
            List<Record> listCount = list.Where(x => (x.Size == game.Board.Size) && (x.Diff == game.Board.Difficul)).ToList();

            if (listCount.Count < 5)
            {
                AddRecord(list, record);

            }
            else
            {
                Record remove = list.FirstOrDefault(x => (x.Size == game.Board.Size) && (x.Diff == game.Board.Difficul) && (x.Time > game.Time));
                if (remove != null )
                {
                    list.Remove(remove);
                    AddRecord(list, record);
                }
            }
           
        }
        private void  AddRecord(List<Record> list, Record record)
        {
            list.Add(record);
            SerializacjaXML serializacjaXML = new SerializacjaXML(list);
            MessageBox.Show("Wynik został dodany do listy rekordów", "Gratulacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
