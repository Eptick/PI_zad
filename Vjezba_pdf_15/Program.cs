﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi tekst i N brojeva. Za
    svaki broj (od N) aplikacija ispisuje jedan red koji sadrži ispis teksta
    odvojenih razmakom broj puta.
    Sve elemente u kodu je nužno propisno imenovati.
 * 
 * WATAFAK!
 */
namespace Vjezba_pdf_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            int[] polje = new int[N];
            for (int i = 0; i < N; i++)
            {
                polje[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < tekst.Length; j++)
                {
                    if (tekst[j] != ' ')
                    {
                        Console.Write(tekst[j]);
                    }
                    else
                    {
                        for (int k = 0; k < polje[i]; k++)
                        {
                            Console.Write(tekst[j]);
                        }
                    }
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
