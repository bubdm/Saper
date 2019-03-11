using SaperGame.FilesGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.Serializacja.Binarna
{
     public class Deserializacja : SerialBin
    {
      private  bool isRead = false;
        public Deserializacja(Game game) : base(game.Player)
        {
            if (Deserial())
            {
          
                int Count = FieldList.Count;
                game.Board.Size= ReadSize(Count);
                game.TimeSet(FieldList[0].time);
                int[] info = ReadShow(FieldList);
                game.Board.Difficul= ReadDiff(info[1], game.Board.Size);
                CreateBoard createBoard = new CreateBoard(game.Board);
                game.Board.WindowGame = CreateWindow.Create(game.Board);
                game.ShowedField = info[0];
                isRead = true;


            }
        }

        public bool IsReadDeserializacja()
        {
            return isRead;
        }
        public List<Field> ShowListField()
        {
            return FieldList;
        }
        private bool Deserial()
        {
          bool result = false;
            try
            {
                FileStream fileStream = new FileStream(Sciezka, FileMode.Open);
                BinaryFormatter serializer = new BinaryFormatter();
                FieldList = (List<Field>)serializer.Deserialize(fileStream);
                fileStream.Close();
                result = true;
                MessageBox.Show("Udałos sie wczytać gre w." + Sciezka, "Wczytaj gre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Brazk zapisanej gry w " + Sciezka, "Brak zapisu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        private int ReadSize(int count)
        {
            int result = 0;
            switch (count)
            {
                case (9*9):
                    result = 1;
                    break;

                case (16*16):
                    result = 2;
                    break;

                case (30*16):
                    result = 3;
                    break;

                default:
                    break;

                 
            }
            return result;
        }

        private int[] ReadShow(List<Field> fields)
        {
            int [] result = new int[2] {0,0};
         
         

            foreach (var item in fields)
            {
                if (item.visible == false)
                {
                    result[0]++;
                }
                if (item.wartosc == -1)
                {
                    result[1]++;
                }

            }

   
            return result;
        }

        public int ReadDiff(int mine ,int size)
        {
            int result = 0;
            int divider = 1;
            if (size == 2)
                divider = 3;
            else if (size == 3)
                divider = 5;

                switch (mine / divider)
                {
                case 10:
                    result = 1;
                    break;
                case 20:
                    result = 2;
                    break;
                case 30:
                    result = 3;
                    break;

                default:
                    break;
                }

            return result;
        }


    }
}
