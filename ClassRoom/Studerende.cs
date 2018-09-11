using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }

        public Studerende(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public void årstid(Studerende enStuderende)
        {
            if (BirthMonth < 3 || BirthMonth == 12)
            {
                Console.WriteLine("Den studerende har fødselsdag ved Vinter");
            }
            else if (BirthMonth < 6 || BirthMonth > 2)
            {
                Console.WriteLine("Den studerende har fødselsdag ved Forår");
            }
            else if (BirthMonth < 9 || BirthMonth > 5)
            {
                Console.WriteLine("Den studerende har fødselsdag ved Sommer");
            }
            else
            {
                Console.WriteLine("Den studerende har fødselsdag ved Efterår");
            }
        }
    }

}
