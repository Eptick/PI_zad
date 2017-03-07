using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_pdf_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            do
            {
                Console.Write("Unesite jedinice: ");
                int prvi = Convert.ToInt16(Console.ReadLine());

                Console.Write("Unesite desetice: ");
                int drugi = Convert.ToInt16(Console.ReadLine());
                drugi = drugi * 10;

                broj = prvi + drugi;
            }  while (broj > 99);
            Console.WriteLine(broj*2);
            Console.ReadLine();
        }
    }
}
