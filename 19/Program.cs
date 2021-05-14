using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            //19
            Console.WriteLine("Введите число c1");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число n1");
            double  n1 = Convert.ToDouble(Console.ReadLine());
            double  c = c1 + n1;
            double x = c1 * 100 / c1 + n1;
            double y = c1 * (100 * x) / 100;
            Console.WriteLine("сумма в %");
            Console.ReadKey();
        }
    }
}
