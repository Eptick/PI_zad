using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * G2 je bilo: "Unesite broj u eksponentnoj notaciji XeY tako da se prvo unosi X,
 * a zatim Y i program mora izračunati (X*10^Y)*2.
 * */
namespace fejs_grupa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine((x * Math.Pow(10, y) )* 2);
            Console.Read();
        }
    }
}
