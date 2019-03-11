using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.FilesGame
{
  public class WindowGame
    {
        public WindowGame(int windowHeigh, int windowWidth )
        {
           this. WindowHeigh = windowHeigh;
            this.WindowWidth = windowWidth;
        }
        public int WindowHeigh { get; private set ; }
        public int WindowWidth { get; private set; }

        public void CLeanWindow()
        {
            WindowHeigh = 0;
            WindowWidth = 0;
        }
    }
}
