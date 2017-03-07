using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi četiri broja, 
 * aplikacija ispisuje brojeve sortirane uzlazno
 * 
 * */
namespace Vjezba_pdf_9
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
            lista.Sort();

            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista[3]);

            Console.ReadLine();
        }
    }
}
