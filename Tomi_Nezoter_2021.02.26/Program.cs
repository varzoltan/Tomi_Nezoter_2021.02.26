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
            StreamReader olvas1 = new StreamReader(@"C:\Users\Rendszergazda\Desktop\Tomi_prog_feladat\kategoria.txt");  
            int n = 0;
            while (!olvas1.EndOfStream)
            {
                string sor = olvas1.ReadLine();
                adatok[n].kategoria = sor;
                n++;
            }
            olvas1.Close();
            StreamReader olvas2 = new StreamReader(@"C:\Users\Rendszergazda\Desktop\Tomi_prog_feladat\foglaltsag.txt");
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

            //3.feladat
            int x = 0;
            for (int i =0; i<n;i++)
            {
                for (int l=0;l<20;l++)
                {
                    if (adatok[i].foglaltsag.Substring(l, 1) == "x")
                    {
                        x++;
                    }
                }
            }
            double szazalek = (double)x / (15*20) * 100.0;
            Console.WriteLine($"Az elődásra eddig {x} jegyet adtak el, ez a nézőszám {szazalek.ToString("0")}%-a.");

            int egy = 0;
            int ketto = 0;
            int harom = 0;
            int negy = 0;
            int ot = 0;
            for (int i =0;i<n;i++)
            {
                for (int j =0;j<20;j++)
                {
                    if (adatok[i].kategoria.Substring(j,1) == "1")
                    {
                        if (adatok[i].foglaltsag.Substring(j, 1) == "x")
                        {
                            egy++;
                        }
                    }
                    if (adatok[i].kategoria.Substring(j, 1) == "2")
                    {
                        if (adatok[i].foglaltsag.Substring(j, 1) == "x")
                        {
                            ketto++;
                        }
                    }
                    if (adatok[i].kategoria.Substring(j, 1) == "3")
                    {
                        if (adatok[i].foglaltsag.Substring(j, 1) == "x")
                        {
                            harom++;
                        }
                    }
                    if (adatok[i].kategoria.Substring(j, 1) == "4")
                    {
                        if (adatok[i].foglaltsag.Substring(j, 1) == "x")
                        {
                            negy++;
                        }
                    }
                    if (adatok[i].kategoria.Substring(j, 1) == "5")
                    {
                        if (adatok[i].foglaltsag.Substring(j, 1) == "x")
                        {
                            ot++;
                        }
                    }
                }
            }
            int[] max = {egy,ketto,harom,negy,ot};
            int max1 = 0;
            for (int i = 0;i<max.Length;i++)
            {
                if (max[i]>max1)
                {
                    max1 = max[i];
                }
            }
                        
            if (max1==egy)
            {
                Console.WriteLine(" a legtöbb jegyet a(z) 1. árkategóriában értékesítették.");
            }
            else if (max1==ketto)
            {
                Console.WriteLine(" a legtöbb jegyet a(z) 2. árkategóriában értékesítették.");
            }
            else if (max1==harom)
            {
                Console.WriteLine(" a legtöbb jegyet a(z) 3. árkategóriában értékesítették.");
            }
            else if (max1==negy)
            {
                Console.WriteLine(" a legtöbb jegyet a(z) 4. árkategóriában értékesítették.");
            }
            else
            {
                Console.WriteLine(" a legtöbb jegyet a(z) 5. árkategóriában értékesítették.");
            }

            //4.feladat
            int[] leg = new int[5];
            int szamol = 0;
            for (int i = 1;i<=5;i++)
            {
                for (int j = 0;j<n;j++)
                {
                    for (int k = 0;k<adatok[j].foglaltsag.Length;k++)
                    {
                        if (adatok[j].foglaltsag[k] == 'x' && adatok[j].kategoria[k] == Convert.ToChar(i))
                        {
                            szamol++;
                        }
                    }
                }
                
                Console.WriteLine(szamol);

                leg[i - 1] = szamol;
                //l++;
                szamol = 0;
            }
            int max2 = 0, p = -1;
            for (int i = 0;i<leg.Length;i++)
            {
                if (leg[i]<max2)
                {
                    max2 = leg[i];
                    p=i;
                }
            }
            Console.WriteLine($"A legnagyobb kategória: {p + 1}");

            //5
            int szamol2 = 0;
            for (int i = 1;i<=5;i++)
            {
                for (int j = 0;j<n;j++)
                {
                    for (int k = 0;k<adatok[j].foglaltsag.Length;k++)
                    {
                        if (adatok[j].foglaltsag[k] == 'x' && adatok[j].kategoria.Substring(k,1) == i.ToString())
                        {
                            if(i == 1)
                            {
                                szamol2 += 5000;
                            }
                            else if(i == 2)
                            {
                                szamol2 += 4000;
                            }
                            else if (i == 3)
                            {
                                szamol2 += 3000;
                            }
                            else if (i == 4)
                            {
                                szamol2 += 2000;
                            }
                            else
                            {
                                szamol2 += 1500;
                            }
                        }
                    }
                }
                Console.WriteLine($"{i} kategória = {szamol2}Ft.");
                szamol2 = 0;
            }

            //6
            int o = 0;
            int egyedulallo = 0;
            for (int i = 0;i<n;i++)
            {
                for (int j = 0;j<adatok[i].foglaltsag.Length;j++)
                {
                    if (adatok[i].foglaltsag[j] == 'x')
                    {
                        egyedulallo += (o / 2);
                        o = 0;
                    }
                    else
                    {
                        o++;
                        if (j == 19)
                        {
                            egyedulallo += o / 2;
                            o = 0;
                        }
                    }
                }
            }
            Console.WriteLine($"6.feladat\n{egyedulallo} ilyen egyedülálló üres hely van a nézőtéren!");
            Console.ReadKey();
        }
    }
}
