using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi broj N.
 * Aplikacija računa i ispisuje sumu prirodnih brojeva od 1 do N.
 * 
 * */
namespace Vjezba_pdf_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj N: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
