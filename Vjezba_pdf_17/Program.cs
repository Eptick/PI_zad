using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi N parova teksta i
boje. Aplikacija ispisuje sav tekst u odgovarajucoj zadanoj boji. Moguće
boje su "Crvena", "Plava" i "Zelena".
Sve elemente u kodu je nužno propisno imenovati
 * 
 * */
namespace Vjezba_pdf_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite N: ");
            int N = int.Parse(Console.ReadLine());
            string[] pt = new string[N];
            string[] pb = new string[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Unesi tekst: ");
                pt[i] = Console.ReadLine();
                Console.WriteLine("Unesi boju: ");
                pb[i] = Console.ReadLine();
            }
            for (int i = 0; i < N; i++)
            {
                switch (pb[i])
                {
                    case "crvena":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "plava":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "zelena":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.WriteLine(pt[i]);
            }
            Console.Read();
        }
    }
}
