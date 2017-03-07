using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi širinu i visinu prozora konzole.
 * Nije moguće unesti vrijednosti manje od 1. Nakon unosa zadnje broja (visine) 
 * veličina prozora konzole se postavi u zadane vrijednosti
 * */
namespace Vjezba_pdf_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, v;
            do
            {
                s = Convert.ToInt16(Console.ReadLine());
            } while (s < 1);
            do
            {
                v = Convert.ToInt16(Console.ReadLine());
            } while (v < 1);

            Console.WindowHeight = s;
            Console.WindowWidth = v;

            Console.Read();

        }
    }
}
