using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaperGame
{[Serializable]
    public class Field
    {
        public Field()
        {

        }
        public Field(int time, int x,int y ,bool visible ,string txt, int wartosc)
        {

            this.x = x;
            this.y = y;
            this.visible = visible;
            this.txt = txt;
            this.wartosc = wartosc;
            this.time = time;
        }


        public int time
        {
            get;

            set;
        }
        public int x
        {
            get;

            set;
        }

        public int y
             {
            get;

            set
                ;}
         public bool visible
         {
            get;

            set;
        }
        public string txt

        {
            get;

            set;
        }
       
        public int wartosc
        {
            get;

            set;
        }

    }
}
