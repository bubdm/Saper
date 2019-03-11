using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SaperGame.Serializacja.XML
{

    [XmlRoot("Record")]
  public  class Record
    {
        public Record()
        {
        }
        public Record(string nick, int diff, int size, int time)
        {
            this.Nick = nick;
            this.Diff = diff;
            this.Size = size;
            this.Time = time;


        }

        [XmlElement("nick")]
        public string Nick
        {
            get; set;
        }
        [XmlElement("diff")]
        public int Diff
        {
            get; set;
        }
        [XmlElement("size")]
        public int Size
        {
            get; set;

        }
        [XmlElement("time")]
        public int Time
        {
            get; set;
        }


    }
}
