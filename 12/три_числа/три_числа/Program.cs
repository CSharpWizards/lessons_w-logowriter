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
            Console.WriteLine("введите три числа и найдите наибольшее из них");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("номер 1 больше ");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("номер 2 больше");
            }
            else
            {
                Console.WriteLine("номер 3 больше");
            }
            Console.ReadLine();

        }
    }
}
