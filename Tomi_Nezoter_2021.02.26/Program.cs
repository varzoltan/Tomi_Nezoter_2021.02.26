using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tomi_Nezoter_2021._02._26
{
    class Program
    {
        struct Adat
        {
            public string kategoria;
            public string foglaltsag;
        }
        static void Main(string[] args)
        {
            //1
            Adat[] adatok = new Adat[15];
            StreamReader olvas1 = new StreamReader(@"C:\Users\Rendszergazda\Downloads\kategoria.txt");  
            int n = 0;
            while (!olvas1.EndOfStream)
            {
                string sor = olvas1.ReadLine();
                adatok[n].kategoria = sor;
                n++;
            }
            olvas1.Close();
            StreamReader olvas2 = new StreamReader(@"C:\Users\Rendszergazda\Downloads\foglaltsag.txt");
            int m = 0;
            while (!olvas2.EndOfStream)
            {
                string sor = olvas2.ReadLine();
                adatok[m].foglaltsag = sor;
                m++;
            }
            olvas2.Close();

            //2
            Console.Write("Kérem adjon meg egy sorszámot: ");
            int sor1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy székszámot: ");
            int szék = int.Parse(Console.ReadLine());
            Console.WriteLine(adatok[sor1 - 1].foglaltsag[szék - 1]);
            if (adatok[sor1-1].foglaltsag[szék-1] == 'x')
            {
                Console.WriteLine("Az adott hely foglalt.");
            }
            else
            {
                Console.WriteLine("Az adott hely szabad.");
            }

            Console.ReadKey();
        }
    }
}
