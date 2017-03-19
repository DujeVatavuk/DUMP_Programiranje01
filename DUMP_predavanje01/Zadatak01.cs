using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_predavanje01
{
    class Zadatak01
    {
        static void Main(string[] args)
        {
            int D1, D2, X1, X2;

            do
            {
                Console.WriteLine("Od kada do kada Ivane ides na put:");
                D1 = int.Parse(Console.ReadLine());
                D2 = int.Parse(Console.ReadLine());
            }while (!(D1 > 1 && D1 < 31 && D2 > 1 && D2 < 31));

            do
            {
                Console.WriteLine("Koje ti je termine prijatelj (ako ih imas) ponudio za tulum Ivane (max 2 termina)?");
                X1 = int.Parse(Console.ReadLine());
                X2 = int.Parse(Console.ReadLine());
            } while (!(X1 > 1 && X1 < 31 && X2 > 1 && X2 < 31));

            Console.WriteLine();

            if (X1 >= D1 && X1 <= D2)
            {
                Console.WriteLine("Ivane, ne mozes ici na zabavu " + X1 + ". u mjesecu");
            }
            else
            {
                Console.WriteLine("Ivane, mozes ici na zabavu " + X1 + ". u mjesecu");
            }

            if (X2 >= D1 && X2 <= D2)
            {
                Console.WriteLine("Ivane, ne mozes ici na zabavu " + X2 + ". u mjesecu");
            }
            else
            {
                Console.WriteLine("Ivane, mozes ici na zabavu " + X2 + ". u mjesecu");
            }

            Console.WriteLine();
        }
    }
}
