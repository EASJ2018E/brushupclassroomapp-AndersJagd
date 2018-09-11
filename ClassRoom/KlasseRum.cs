using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
           
        }

        public void årstidscounter(List<Studerende> enListe)
        {
            int VinterCounter = 0;
            int ForårCounter = 0;
            int SommerCounter = 0;
            int EfterårCounter = 0;

            foreach (var studerende in enListe)
            {
                if (studerende.BirthMonth < 3 || studerende.BirthMonth == 12)
                {
                    VinterCounter++;
                }
                else if (studerende.BirthMonth < 6 || studerende.BirthMonth > 2)
                {
                    ForårCounter++;
                }
                else if (studerende.BirthMonth < 9 || studerende.BirthMonth > 5)
                {
                    SommerCounter++;
                }
                else
                {
                    EfterårCounter++;
                }

            }

            Console.WriteLine($"Fødselsdage i: Vinter {VinterCounter} | Forår {ForårCounter} | Sommer {SommerCounter} | Efterår {EfterårCounter}");
        }
    }
}
