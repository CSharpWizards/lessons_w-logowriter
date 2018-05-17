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
            Console.WriteLine("привет, можно скажешь сколько тебе лет и мы узнаем подросток ли ты");
            int years = int.Parse(Console.ReadLine());
            if (years >= 10 && years<20)
            {
                Console.WriteLine("вы подросток");
            }
           
            else
            {
                Console.WriteLine("вы пока не подросток");
            }

            
            Console.ReadLine();
        }
    }
}
