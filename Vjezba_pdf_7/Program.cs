using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju koja crta srce visine minimalno 5 redova
 * i u zadanoj boji koju korisnik unese ("Crvena", "Plava")
 * */
namespace Vjezba_pdf_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string boja = Console.ReadLine();
            switch (boja)
            {
                case "Crvena":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Plava":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            Console.Write(" °° °°\n°  °  °\n°     °\n °   °\n   °\n");
            
            Console.ReadLine();
        }
    }
}
