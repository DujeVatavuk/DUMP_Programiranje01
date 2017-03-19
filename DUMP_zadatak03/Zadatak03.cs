using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak03
{
    class Zadatak03
    {
        static void Main(string[] args)
        {
            string operacija;
            do
            { 
                Console.WriteLine("Molim vas, unesite operaciju koju zelite izvrsiti, a ako zelite zavrsiti upisite KRAJ");
                operacija = Console.ReadLine();
                operacija=operacija.ToLower();
                switch (operacija)
                {
                    case "zbrajanje":
                        Console.WriteLine("Zbroj vasa dva broja je: " + Zbrajanje());
                        break;
                    case "dijeljenje":
                        Console.WriteLine("Kvocijent vasa dva broja je: " + Dijeljenje());
                        break;
                    case "oduzimanje":
                        Console.WriteLine("Razlika vasa dva broja je: " + Oduzmanje());
                        break;
                    case "mnozenje":
                        Console.WriteLine("Umnozak vasa dva broja je: " + Mnozenje());
                        break;

                    default:
                        Console.WriteLine("Ta operacija ne postoji, molim vas pokusajte ponovo");
                        break;
                }
            }while(operacija!="kraj");
        }
        public static double Zbrajanje()
        {
            Console.WriteLine("Unesite prvi broj");
            double prviBroj = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi  broj");
            double drugiBroj = double.Parse(Console.ReadLine());
            return prviBroj+drugiBroj;
        }
        public static double Oduzmanje()
        {
            Console.WriteLine("Unesite prvi broj");
            double prviBroj = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj");
            double drugiBroj = double.Parse(Console.ReadLine());
            return prviBroj-drugiBroj;
        }
        public static double Dijeljenje()
        {
            Console.WriteLine("Unesite prvi broj");
            double prviBroj = double.Parse(Console.ReadLine());
            double drugiBroj;
            do
            {
                Console.WriteLine("Unesite drugi broj");
                drugiBroj = double.Parse(Console.ReadLine());
            } while (drugiBroj == 0);
            return prviBroj/drugiBroj;
        }
        public static double Mnozenje()
        {
            Console.WriteLine("Unesite prvi broj");
            double prviBroj = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi  broj");
            double drugiBroj = double.Parse(Console.ReadLine());
            return prviBroj*drugiBroj;
        }
    }
}
