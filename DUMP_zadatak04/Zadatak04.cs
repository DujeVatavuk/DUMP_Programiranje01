using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak04
{
    class Zadatak04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konichiwa Ishimuro :3 (so kawaii)");
            Console.WriteLine("Koliko si ribe danas ulovija?");
            int brojRibe = int.Parse(Console.ReadLine());
            int[] konichiVar1 = new int[brojRibe];
            int prvaVrijednost = 0;
            int drugaVrijednost = 0;
            int dozvoljnaTolerancija = 100;
            int ukupnaVrijednostRibe = 0;


            for (int i = 0; i < brojRibe; i++)
            {
                Console.Write("Upisi prvu vrijednost " + (i+1) + ". ribe: ");
                prvaVrijednost = int.Parse(Console.ReadLine());
                Console.Write("Upisi drugu vrijednost " + (i + 1) + ". ribe: ");
                drugaVrijednost = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (Math.Abs(prvaVrijednost - drugaVrijednost) >= dozvoljnaTolerancija)
                {
                    if (prvaVrijednost >= drugaVrijednost)
                    {
                        konichiVar1[i] = prvaVrijednost;
                    }
                    else
                    {
                        konichiVar1[i] = drugaVrijednost;
                    }
                }
                else
                {
                    if (prvaVrijednost <= drugaVrijednost)
                    {
                        konichiVar1[i] = prvaVrijednost;
                    }
                    else
                    {
                        konichiVar1[i] = drugaVrijednost;
                    }
                }
            }

            for(int i = 0; i < brojRibe; i++)
            {
                ukupnaVrijednostRibe += konichiVar1[i];
            }

            Console.WriteLine("Ukupna vrijednost ribe je: " + ukupnaVrijednostRibe + " yen");
        }
    }
}
