using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Napravite konzolnu aplikaciju u kojoj korisnik unosi dva broja i 
 * operator (+,-,*,/), aplikacija ispisuje rezultat matematičke operacije
 * */
namespace Vjezba_pdf_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvi = Convert.ToInt16(Console.ReadLine());
            int drugi = Convert.ToInt16(Console.ReadLine());

            string op = Console.ReadLine();
            float r;
            switch (op[0])
            {
                case  '+':
                    r = prvi + drugi;
                    break;
                case '-':
                    r = prvi - drugi;
                    break;
                case '/':
                    r = prvi / drugi;
                    break;
                case '*':
                    r = prvi * drugi;
                    break;
                default:
                    r = 0;
                    break;
            }
            Console.WriteLine(r);
            Console.ReadLine();

        }
    }
}
