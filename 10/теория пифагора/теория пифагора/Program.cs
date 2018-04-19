using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите 1-ю сторону треугольника ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите 2-ю сторону треугольника ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("введите 3-ю сторону треугольника ");
            int c = int.Parse(Console.ReadLine());
            if (c + a > b)
            {
                Console.WriteLine("этот треугольник  может существовать");
            }
            else {
                Console.WriteLine("этот треугольник  не может существовать");
            }
            Console.ReadLine();
        }
    }
}
