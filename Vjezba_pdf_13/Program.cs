using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi broj duljine N
znamenki. Broj se zapisuje u polje (int) tako da svaka znameka bude u
odgovarajućem elementu polja. Aplikacija zatim ispisuje sadržaj polja
gdje je svaki element odvojen zarezom
Sve elemente u kodu je nužno propisno imenovati.
 * */

namespace Vjezba_pdf_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string linija = Console.ReadLine();
            int N = linija.Length;
            int[] polje = new int[N];
            for (int i = 0; i < N; i++)
            {
                polje[i] = int.Parse(linija[i].ToString() );
                Console.Write(polje[i] + ", ");
            }
            Console.Read();
        }
    }
}
