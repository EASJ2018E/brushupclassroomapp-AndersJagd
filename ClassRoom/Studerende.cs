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
        public string Name { get; }
        public int BirthMonth { get; }
        public int BirthDay { get; }

        public Studerende(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public string årstid(Studerende enStuderende)
        {
            if (BirthMonth < 3 || BirthMonth == 12)
            {
                return "Vinter";
            }
            else if (BirthMonth < 6 || BirthMonth > 2)
            {
                return "Forår";
            }
            else if (BirthMonth < 9 || BirthMonth > 5)
            {
                return "Sommer";
            }
            else
            {
                return "Efterår";
            }
        }



    }

}
