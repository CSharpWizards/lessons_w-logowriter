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
            { // создаем генератор случайных чисел
                Random rand = new Random();

                // генерируем и сохраняем число в диапазоне от 0 до 10
                int a = rand.Next(0, 10);

                // генерируем и сохраняем число в диапазоне от 0 до 10
                int b = rand.Next(0, 10);

                // генерируем и сохраняем число в диапазоне от 0 до 10
                int c = rand.Next(0, 10);
                Console.WriteLine(a+" "+ b+" "+ c);
                int result = int.Parse(Console.ReadLine());
                if (result == a + b + c)
                {
                    Console.WriteLine("ура!!!!!!!!!!");
                    Console.ReadLine();
                    break;
                }
                else {
                    Console.WriteLine("опять !!!");
                }
            }
     
        }
    }
}
