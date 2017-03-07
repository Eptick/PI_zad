using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi tekst i broj.
 * Aplikacija ispisuje uneseni tekst broj puta.
 * */
namespace Vjezba_pdf_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tekst: ");
            String t = Console.ReadLine();
            Console.WriteLine("Unesite broj: ");
            int b = Convert.ToInt16(Console.ReadLine());
            while (b>0)
            {
                Console.WriteLine(t);
                b--;
            }
            Console.ReadLine();

        }
    }
}
