using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi tekst i boju.
 * Aplikacija ispisuje tekst u zadanoj boji. Moguće boje su "Crvena", "Plava" i "Zelena"
 *  */
namespace Vjezba_pdf_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string c = Console.ReadLine();
            switch (c)
            {
                case "Crvena":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Plava":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Zelena":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
