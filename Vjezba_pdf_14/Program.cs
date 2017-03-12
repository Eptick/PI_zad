using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju koja je kontinuirani kalkulator u kojoj
korisnik unosi broj i operator (+,-,*,/). Aplikacija ispisuje rezultat
matematičke operacije sa unesenim brojem i prethodnim rezultatom.
Aplikacija završava ukoliko rezultat ikada bude X.
Sve elemente u kodu je nužno propisno imenovati.
 * 
 * Kako je ovo jebeno glup zadan zadatak, koji jebeni kurac se ovdje traži
 * šta oni s ovim misle. Ovo je debilana.
 * */

namespace Vjezba_pdf_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite X:");
            int X = int.Parse(Console.ReadLine());
            float rez = 0; int broj = 0;
            Console.WriteLine("Unesite broj: ");
            rez = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Unesite operaciju: ");
                string op = Console.ReadLine();
                Console.WriteLine("Unesite broj: ");
                broj = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case "+":
                        rez += broj;
                        break;
                    case "-":
                        rez -= broj;
                        break;
                    case "*":
                        rez *= broj;
                        break;
                    case "/":
                        rez /= broj;
                        break;
                }
            } while (rez != X);
            
        }
    }
}
