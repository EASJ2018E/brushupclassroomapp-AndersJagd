using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasse1 = new KlasseRum();
            Studerende Anders = new Studerende("Anders", 02, 28);
            Studerende Nicolai = new Studerende("Nicolai", 12, 19);
            Studerende Patrick = new Studerende("Patrick", 08, 07);

            klasse1.KlasseNavn = "3B";
            klasse1.SemesterStart = new DateTime(4/9/2018);
            klasse1.Klasseliste.Add(Anders);
            klasse1.Klasseliste.Add(Nicolai);
            klasse1.Klasseliste.Add(Patrick);


            Console.WriteLine($"Klasse Navn: {klasse1.KlasseNavn}, Semester start: {klasse1.SemesterStart}");
            klasse1.Klasseliste.ForEach(studerende => { Console.WriteLine($"{studerende.Name}"); });

            Console.ReadKey();

        }
    }
}
