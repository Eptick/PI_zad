using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi N brojeva. Aplikacija
ispisuje unesene brojeve u jednom redu. U drugom redu za svaki broj
ispisuje apsolutno odstupanje od prosjeka čitavog niza unesenih N
brojeva.
 * 
 * */
namespace Vjezba_pdf_21
{
    class Zadatak
    {
        int N;
        int[] polje;
        int prosjek;
        public void Unos()
        {
            Console.WriteLine("Unesite N: ");
            N = int.Parse(Console.ReadLine());
            polje = new int[N];
            int suma = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Unesite {0} element: ", i);
                polje[i] = int.Parse(Console.ReadLine());
                suma += polje[i];
            }
            prosjek = suma / N;
            Ispis();
        }
        void Ispis()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", polje[i]);
            }
            Console.WriteLine(" ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", Odstupanje(polje[i]));
            }
            Console.WriteLine(" ");
        }
        int Odstupanje(int element)
        {
            return Math.Abs(prosjek - element);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak z = new Zadatak();
            z.Unos();
            Console.Read();
        }
    }
}
