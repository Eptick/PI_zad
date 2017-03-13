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

namespace Vjezba_pdf_klasa_12
{
    class Zadatak
    {
        public float prvi;
        public float drugi;
        string ispis;
        public void Unos()
        {
            string linija = Console.ReadLine();
            string[] polje = linija.Split(' ');
            prvi = float.Parse(polje[0]);
            drugi = float.Parse(polje[1]);
            ispis = polje[2];
            Provjera();
        }
        private void Provjera()
        {
            if (prvi > drugi)
            {
                float t = prvi;
                prvi = drugi;
                drugi = t;
            }
        }
        public void Ispis()
        {
            if (ispis == "u")
            {
                for (int i = (int)prvi; i < drugi; i++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            else if (ispis == "s")
            {
                for (int i = (int)drugi; i > drugi; i--)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak z = new Zadatak();
            z.Unos();
            z.Ispis();
            Console.Read();
        }
    }
}
