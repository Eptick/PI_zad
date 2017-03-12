using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi:
- dva decimalna broja
- razmak između dva broja
- uzlaznost ili silaznost ispisa
Aplikacija ispisuje sve brojeve između ta dva broja ovisno o ulaznim
parametrima.
Sve elemente u kodu je nužno propisno imenovati
 * */

namespace Vjezba_pdf_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string linija = Console.ReadLine();
            string[] polje = linija.Split(' ');
            float prvi = float.Parse(polje[0]);
            float drugi = float.Parse(polje[1]);
            if (prvi > drugi)
            {
                float t = prvi;
                prvi = drugi;
                drugi = t;
            }
            if (polje[2] == "u")
            {
                for (int i = (int)prvi; i < drugi; i++)
                {
                    Console.WriteLine(i);
                }
            }

            if (polje[2] == "s")
            {
                for (int i = (int)drugi; i > prvi; i--)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();

        }
    }
}
