using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* Triba unit N koji će nam biti veličina polja. Svaki element polja predstavlja boju.
 * Ispisati trenutno vrijeme u određenoj boji (beskonačnom petljom). 
 * Ispis svakog elementa zapocinje pritiskom tipke Enter. 
 */
namespace fejs_zadatak_1_tjedan_2
{
    class Zadatak
    {
        string[] polje;
        int N;
        public void Unos()
        {
            Console.Write("Unesite N: ");
            N = int.Parse(Console.ReadLine());
            polje = new string[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Unesite boju: ");
                polje[i] = Console.ReadLine();
            }
            Ispis();
        }
        void MjenjajBoju(int i)
        {
            switch (polje[i].ToLower())
            {
                case "crvena":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "plava":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "zelena":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }
        void Ispis()
        {
            for (int i = 0; i < N; i++)
            {
                MjenjajBoju(i);
                while (true)
                {
                    while (Console.KeyAvailable == false)
                    {
                        Thread.Sleep(250); 
                        Console.Clear();
                        Console.WriteLine(DateTime.Now);
                    }
                        
                    ConsoleKeyInfo pritisnutaTipka = Console.ReadKey(true);
                    if (pritisnutaTipka.Key == ConsoleKey.Enter)
                        break;
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
            Console.Read();
        }
    }
}
