using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_pdf_23
{
    class Program
    {
        static int N;
        static BinarniBroj[] poljeBrojeva;
        static void Main(string[] args)
        {
            Unos();
            Ispis();
            Console.Read();
        }
        static void Unos()
        {
            Console.Write("Unesite koliko binarnih brojeva zelite: ");
            N = int.Parse(Console.ReadLine());
            poljeBrojeva = new BinarniBroj[N];
            for (int i = 0; i < N; i++)
            {
                try
                {
                    Console.Write("Unesite binarni broj: ");
                    poljeBrojeva[i] = new BinarniBroj(Console.ReadLine());
                }
                catch (WrongBitNumber)
                {
                    Console.WriteLine("Pogresan broj bitova!");
                    poljeBrojeva[i] = new BinarniBroj("00000000");
                }
            }
        }
        static void Ispis()
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0} - {1}", poljeBrojeva[i].Binarni(), poljeBrojeva[i].DecimalnaVrijednost());
            }
        }
    }
}
