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
            Console.WriteLine("введите сначала кол-во жителей в городе а потом площадь города");
            double kolvo = int.Parse(Console.ReadLine());
            double area = int.Parse(Console.ReadLine());
            Console.WriteLine(kolvo / area);
            Console.ReadLine();
        }
    }
}
