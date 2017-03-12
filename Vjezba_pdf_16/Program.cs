using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi N brojeva. Aplikacija
računa i ispisuje kumulativni niz unesenih brojeva.
Sve elemente u kodu je nužno propisno imenovati.
 * */
namespace Vjezba_pdf_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inesite N: ");
            int N = int.Parse(Console.ReadLine());
            int[] polje = new int[N];
            for (int i = 0; i < N; i++)
            {
                polje[i] = int.Parse(Console.ReadLine());
            }
            int s = 0;
            for (int i = 0; i < N; i++)
            {
                s += polje[i];
                Console.Write(s);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
        
    }
}
