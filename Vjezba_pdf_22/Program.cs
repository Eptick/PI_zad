using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi širinu i visinu prozora
konzole. Nije moguće unesti vrijednosti manje od 1. Nakon unosa
zadnjeg broja (visine) veličina prozora konzole je minimalne veličine te
se postupno (svake X milisekunde) povecava za 1 do zadane širine i
visine
 * 
 * */
namespace Vjezba_pdf_22
{
    class Zadatak
    {
        int sirina;
        int visina;
        int x;
        public void Unos()
        {
            do
            {
                Console.Write("Unesite sirinu prozora: ");
                sirina = int.Parse(Console.ReadLine());
            } while (sirina < 1);

            do
            {
                Console.Write("Unesite visinu prozora: ");
                visina = int.Parse(Console.ReadLine());
            } while (visina < 1);
            Console.Write("Unesite koliko milisekundi: ");
                x = int.Parse(Console.ReadLine());
            Povecavaj();
        }
        void Povecavaj()
        {
            Console.WindowHeight = 1;
            Console.WindowWidth = 1;
            while (Console.WindowHeight < visina || Console.WindowWidth < sirina)
            {
                if (Console.WindowHeight < visina)
                    Console.WindowHeight++;
                if (Console.WindowWidth < sirina)
                    Console.WindowWidth++;
                Thread.Sleep(x);
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
