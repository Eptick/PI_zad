using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3. Upis dva broja i ispis njihovog umnoska ali bez mnozenja (*)
 * */
namespace fejs_grupa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi = Convert.ToInt16(Console.ReadLine());
            int drugi = Convert.ToInt16(Console.ReadLine());
            int u = prvi;
            for (int i = 1; i < drugi; i++)
                u += prvi;

            Console.WriteLine(u);
            Console.Read();
        }
    }
}
