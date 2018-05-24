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

            while (true)
            {
                Console.WriteLine("введите число и мы выведем его квадрат");
                int number = int.Parse(Console.ReadLine());
                number = number * number;
                Console.WriteLine(number);



            }

        }
    }
}
