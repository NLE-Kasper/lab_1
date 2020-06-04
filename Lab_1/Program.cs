using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            const double radius = 3;
            Console.Write("X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (((x * y < 0) || (Math.Abs(y) > Math.Abs(y)) || (Math.Abs(radius - y) * Math.Abs(radius - y) + Math.Abs(radius - x) * Math.Abs(radius - x) > radius * radius)))
                Console.WriteLine("Не принадлежит.");
            else
                Console.WriteLine("Принадлежит.");
            Console.ReadLine();
        }
    }
}
