using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi dva broja,
 * aplikacija ispisuje sve brojeve između ta dva broja
 * koji su dijeljivi za unesenim trećim brojem
 * 
 * */
namespace Vjezba_pdf_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi = Convert.ToInt16(Console.ReadLine());
            int drugi = Convert.ToInt16(Console.ReadLine());
            int treci = Convert.ToInt16(Console.ReadLine());
            for (int i = prvi; i < drugi; i++)
            {
                if (i % treci == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
