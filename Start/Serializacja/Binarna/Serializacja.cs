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
   public class Serializacja : SerialBin
    {


        public Serializacja( Game game) : base(game.Player)
        {
            if (Directory.Exists(Folder) == false)
            {
                Directory.CreateDirectory(Folder);
                MessageBox.Show("\nFolder: " + Folder + " został utworzony.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Serial_bin(game);

        }


        private void Serial_bin(Game game)
        {



            for (int x = 0; x < game.Board.Width; x++)
            {
                for (int y = 0; y < game.Board.Heigh; y++)
                {      
                    FieldList.Add(new Field(game.Time, x, y, game.Board.GameBoard.Btn_grid[x, y].Visible, game.Board.GameBoard.Lbl_grid[x, y].Text, game.Board.GameBoard.Grid[x, y]));

                }
            }
            try
            {
                FileStream fileStream = new FileStream(Sciezka, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fileStream, FieldList);
                fileStream.Close();

                MessageBox.Show("Udałos sie zapisac gre w." + Sciezka, "Zapisanie gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd." + Sciezka, "Wystąpienie jakiegoś błedu przy otwarciu pliku ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
