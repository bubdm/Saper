using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaperGame.FilesGame
{
 public   class Player
    {
        public string Nick { get; private set; }

        public Player( string nick)
        {
            this.Nick = nick;
        }

    }
}
