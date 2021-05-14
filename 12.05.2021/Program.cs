using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число o1");
            double o1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число o2");
            double o2 = Convert.ToDouble(Console.ReadLine());
            double y = a * x1 + b;
            double x = y1 - a * x1;
            double y = y1 - y2 / x1 - x2;
            Console.WriteLine("y");
            Console.ReadKey();   


        }
    }
}
