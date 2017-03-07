using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi pet brojeva.
 * aplikacija ispisuje unesene brojeve u jednom redu. u drugom redu ispisuje sumu i prosijek
 * */
namespace Vjezba_pdf_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int16> lista = new List<Int16>();
            lista.Add(Convert.ToInt16(Console.ReadLine()));
            lista.Add(Convert.ToInt16(Console.ReadLine()));
            lista.Add(Convert.ToInt16(Console.ReadLine()));
            lista.Add(Convert.ToInt16(Console.ReadLine()));
            lista.Add(Convert.ToInt16(Console.ReadLine()));
            Console.Write(lista[0]);
            Console.Write(" ");
            Console.Write(lista[1]);
            Console.Write(" ");
            Console.Write(lista[2]);
            Console.Write(" ");
            Console.Write(lista[3]);
            Console.Write(" ");
            Console.Write(lista[4]);
            Console.Write("\n");
            int suma = 0, prosjek = 0;

            for (int i = 0; i < 5; i++)
            {
                suma += lista[i];
            }
            prosjek = suma / 5;
            Console.Write(suma);
            Console.Write(" ");
            Console.Write(prosjek);
            Console.ReadLine();
        }
    }
}
