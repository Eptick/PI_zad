using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2. Upis dva broja i za ispis prvi na drugi (potenciranje)
 * */
namespace fejs_grupa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi = Convert.ToInt16(Console.ReadLine());
            int drugi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Math.Pow(prvi, drugi));
            Console.Read();
        }
    }
}
