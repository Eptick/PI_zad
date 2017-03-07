using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Upis dva broja i treba ispisati sve brojeve izmedu njih koji ne zavrsavaju na 0
 * */
namespace fejs_grupa_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi = Convert.ToInt16(Console.ReadLine());
            int drugi = Convert.ToInt16(Console.ReadLine());

            for (int i = prvi; i < drugi; i++)
            {
                String b = i.ToString();
                if (b[b.Length - 1] != '0')
                {
                    Console.WriteLine(b);
                }
            }
            Console.Read();
        }
    }
}
