using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi N parova cijelih
brojeva. Nakon što je uneseno svih N parova brojeva, brojeve je
potrebno ispisati u obliku:
(prviBrojPara < drugiBrojPara) ili
(prviBrojPara > drugiBrojPara) ili
(prviBrojPara = drugiBrojPara).
Sve elemente u kodu je nužno propisno imenovati
 * 
 * */
namespace Vjezba_pdf_20
{
    class Zadatak
    {
        int[,] parovi;
        int N;
        public void Unos()
        {
            Console.Write("Unesite N: ");
            N = int.Parse(Console.ReadLine());
            parovi = new int[N,2];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Unesite par(odvojen razmakom): ");
                string linija = Console.ReadLine();
                parovi[i, 0] = int.Parse(linija.Split(' ')[0]);
                parovi[i, 1] = int.Parse(linija.Split(' ')[1]);
            }
            Obrada();
        }
        void Obrada()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(parovi[i, 0]);
                if(parovi[i, 0] < parovi[i, 1])
                    Console.Write(" < ");
                if (parovi[i, 0] > parovi[i, 1])
                    Console.Write(" > ");
                if (parovi[i, 0] == parovi[i, 1])
                    Console.Write(" == ");
                Console.WriteLine(parovi[i, 1]);
            }
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
