using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // OVO JE DODANO ZA SLEEP!!

/*
 * Napravite konzolnu aplikaciju koja crta pravokutnik zadanih dimenzija i u
zadanoj boji koju korisnik unese ("Crvena", "Plava", "Zelena").
Nakon unosa, svake sekunde aplikacija mijenja boju prikazanog
pravokutnika iz bijele u zadanu i tako u nedogled.
Sve elemente u kodu je nužno propisno imenovati
 * 
 * */

namespace Vjezba_pdf_18
{
    class Zadatak
    {
        private int x;
        private int y;
        string boja, boja2;
        public void Unos()
        {
            Console.WriteLine("Unesite sirinu:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite visinu:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite boju:");
            boja2 = Console.ReadLine();
            boja = boja2;

            Ispis();
        }
        void Ispis()
        {
            Console.Clear();
            while (true)
            {

                switch (boja.ToLower()) // moguce i switch(boja) // Ovo ToLower() služi da se pretvori u mala slova, da se može unest (Crvena, Plava, Zelena)
                {
                    case "crvena":
                        Console.ForegroundColor = ConsoleColor.Red;
                        boja = "bela";
                        break;
                    case "plava":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        boja = "bela";
                        break;
                    case "zelena":
                        Console.ForegroundColor = ConsoleColor.Green;
                        boja = "bela";
                        break;
                    case "bela":
                        Console.ForegroundColor = ConsoleColor.White;
                        boja = boja2;
                        break;
                }
                Console.CursorTop = 0;
                Console.CursorLeft = 0;
                for (int i = 0; i < x; i++)
                {
                    Console.Write("-");
                }
                Console.CursorTop = 1;
                Console.CursorLeft = 0;
                for (int i = 1; i < y-1; i++)
                {
                    Console.Write("|");
                    Console.CursorLeft = x-1;
                    Console.WriteLine("|");
                }
                for (int i = 0; i < x; i++)
                {
                    Console.Write("-");
                }
                Thread.Sleep(1000);
            }
            
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak z = new Zadatak();
            z.Unos();

        }
    }
}
