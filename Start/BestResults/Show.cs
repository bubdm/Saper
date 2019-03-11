using SaperGame.Serializacja.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperGame.BestResults
{
    
 public  class Show
    {
     
        public Show(List<Record> list)
        {
            Ranking_form ranking_Form = new Ranking_form(Write(list));
            ranking_Form.ShowDialog();     
        }

        public string Write(List<Record> list)
        {
            List<Record> result = null;
            string text = "";

            if (list == null)

            {
                return text= "Brak listy wyników";
            }
                text = " Ranking Najlepszych wyników :\n\n";


            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {


                    text += " Poziom trudności: " + DeffText(j) + " Rozmiar planszy: " + SizeText(i) + "\n";
                    {
                        result = list.Where(x => (x.Size == i) && (x.Diff == j)).OrderBy(x => x.Time).ToList();


                        if (result.Count > 0)
                        {
                            int count = 1;
                            foreach (var item in result)
                            {
                                text += " " + count + " Gracz :" + item.Nick + "  Czas : " + item.Time + " \n";
                                count++;
                            }
                        }
                        else
                            text += "\n Brak wyników \n \n";


                    }

                }


            }
            return text;
        }

        public string SizeText(int size)
        {
            string result = "";
            switch (size)
            {
                case 1:
                    result = " Mała ";
                    break;
                case 2:
                    result = " Średnia ";
                    break;
                case 3:
                    result = " Duża ";
                    break;
                default:
                    break;
            }

         return   result;
        }

        public string DeffText(int deff)
        {
            string result = "";
            switch (deff)
            {
                case 1:
                    result = " Łatwy ";
                    break;
                case 2:
                    result = " Normalny ";
                    break;
                case 3:
                    result = " Trudny ";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
