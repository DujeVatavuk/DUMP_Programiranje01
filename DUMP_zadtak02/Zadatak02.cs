using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak02
{
    class Zadatak02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koliko se ljudi javilo?");
            int brojLjudiKoiSuSeJaviliDaOdgovoreNaPitanjeIMozdaGaTocnoOdgovorili = int.Parse(Console.ReadLine());

            int j = 0, brojBombonaKojiJeKlaraDalaNekojOsobiKojaSeJavilaDaMozdaTocnoOdgovoriNaPitanje;

            for (int i = 1; i < brojLjudiKoiSuSeJaviliDaOdgovoreNaPitanjeIMozdaGaTocnoOdgovorili + 1; i++) 
            {
                Console.WriteLine("Koliko si bombona dobio " + i + ". osobo?");
                brojBombonaKojiJeKlaraDalaNekojOsobiKojaSeJavilaDaMozdaTocnoOdgovoriNaPitanje = int.Parse(Console.ReadLine());
                if (brojBombonaKojiJeKlaraDalaNekojOsobiKojaSeJavilaDaMozdaTocnoOdgovoriNaPitanje < i)
                {
                    j++;
                }
            }
            Console.WriteLine();
            if (j == 0)
            {
                Console.WriteLine("Klara bravo, nemas nezadovoljnih ljudi");
            }
            else if (j==1)
            {
                Console.WriteLine("Close enough Klara, samo jedna nezadovoljna osoba");
            }
            else
            {
                Console.WriteLine("Klara, Klara, jao, jao, imas " + j + " nezadovoljnih ljudi, ccc");
            }
        }
    }
}
