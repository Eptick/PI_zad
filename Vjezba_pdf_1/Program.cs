using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_pdf_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            int prvi = Convert.ToInt16(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int drugi = Convert.ToInt16(Console.ReadLine());

            if (prvi > drugi)
            {
                int t = prvi;
                prvi = drugi;
                drugi = t;
            }

            for (int i = prvi; i <= drugi; i++)
                Console.WriteLine(i);

            Console.Read();            
        }
    }
}
