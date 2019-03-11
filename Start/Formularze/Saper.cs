using SaperGame.Serializacja.Binarna;
using SaperGame.Obiekty;
using SaperGame.FilesGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaperGame.Serializacja.XML;
using SaperGame.BestResults;

namespace SaperGame
{ 

    public partial class Saper : Form
    {
        #region Zmienne
        double procent;
        Game game;     
        int startX = 15, startY = 68;
        #endregion

        #region Konstruktor

        public Saper()
        {
            InitializeComponent();
            
        }
        public Saper(Player player)
        {
           
            InitializeComponent();
            Board board = new Board(startX, startY);
            this.Visible = false;
            game = new Game(player, board);
            SettingsBoard newGame = new SettingsBoard(this, board);
            newGame.Show();

        }
        #endregion

        #region Infromacje
        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
        }
        #endregion

        #region Pomoc
        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
        }

        #endregion

        #region Ranking
        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            DeserializacjaXML deserializacjaXML = new DeserializacjaXML();
            Show show = new Show(deserializacjaXML.ShowList());
        
        }
        #endregion

        #region Plik
        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Wyczysc();
            game.Board.CleanBoard();
            SettingsBoard newGame = new SettingsBoard(this, game.Board);
            newGame.Show();
          
        }

        private void zapiszGreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializacja.Binarna.Serializacja serializacja = new Serializacja.Binarna.Serializacja(game);
      
        }

        private void wczytajGreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Read();
      
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Metody


     
        public void Window()
        {
            int sizeWidth = game.Board.WindowGame.WindowWidth;
            if (sizeWidth < 338)
            {
                sizeWidth = 338;
            }
            int sizeHeigh = game.Board.WindowGame.WindowHeigh;
            this.Width = sizeWidth;
            this.Height = sizeHeigh;
            this.MaximumSize = new System.Drawing.Size(sizeWidth, sizeHeigh);
            this.MinimumSize = new System.Drawing.Size(sizeWidth, sizeHeigh);
        }
 
        private void timer_Tick(object sender, EventArgs e)
        {
            game.TimePlus(1);
            time_label.Text = game.Time.ToString();
            procent = ((double)game.ShowedField / (double)game.Board.FieldCountWithOutMine) * 100;///
            procent_label.Text = procent.ToString("0.00")+"%";


            if(procent==100)
            {
                timer.Enabled = false;
                lose_b.Visible = false;
                MessageBox.Show("Gratuluje wygrałeś z czasem " + time_label.Text, "Wygrałeś", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Add add = new Add(game);        
             
            }
        }

        private void Wyczysc()
        {
            if(game.Board.GameBoard != null)
            {
                CleanGame clean = new CleanGame(game,this);
                game.Board.GameBoard = null;
            }
        }

        private void lose_b_Click(object sender, EventArgs e)
        {
            lose_b.Visible = false;
            timer.Enabled = false;
            EndGame end = new EndGame(game);     
        }

        public void StartGame()
        {
          
            Wyczysc();
            FillBoard  fill = new FillBoard(game, this);

            mine_label.Text = game.Board.MineCount.ToString();

     
            procent_label.Text = "0";
            game.TimeClean();
            game.ShowedField = 0;


            Window();

            timer.Start();
            lose_b.Visible = true;
        }

        public void DodajZdarzenie(Button button)
        {        
            button.MouseClick += Button_MouseClick;
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled)
            {
                return;
            }
            Button bttnClick = sender as Button;
            if (bttnClick == null)
            {
                return;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (bttnClick.Text == "x")
                {
                    bttnClick.Text = "";
                }
                else
                {
                    bttnClick.Text = "x";
                }
                return;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {


                string[] split = bttnClick.Name.Split(new Char[] { ' ' });

                int x = System.Convert.ToInt32(split[0]);
                int y = System.Convert.ToInt32(split[1]);



                if (game.Board.GameBoard.Grid[x, y] == -1)
                {
                    lose_b.Visible = false;
                    EndGame end = new EndGame(game);
                    timer.Enabled = false;

                }

                ShowField show = new ShowField(x, y, game);
                bttnClick.Visible = false;
            }

        }

  

        private void Saper_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void Read()
        {



            Wyczysc();
            game.Board.CleanBoard();
            Deserializacja deserializacja = new Deserializacja(game);
            if (deserializacja.IsReadDeserializacja())
            {
                Window();
                ReadBoard fill = new ReadBoard(game, this, deserializacja.ShowListField());

                time_label.Text = game.Time.ToString();
                procent = ((double)game.ShowedField / (double)game.Board.FieldCountWithOutMine) * 100;///
                procent_label.Text = procent.ToString("0.00") + "%";
                mine_label.Text = game.Board.MineCount.ToString();

           


                timer.Start();
                lose_b.Visible = true;
            }
            else
            {
                nowaGraToolStripMenuItem_Click(this, null);
            }
        
        }

        #endregion
    }
}
