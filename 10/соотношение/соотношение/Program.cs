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
            Console.WriteLine("сколько игр ты сыграл ?");
            double games = double.Parse(Console.ReadLine());
            Console.WriteLine("сколько из них ты выиграл ?");
            double winGames = double.Parse(Console.ReadLine());
            double ratio = winGames / games;
            Console.WriteLine("ваш винрейт равен "+ ratio );
            Console.ReadLine();

        }
    }
}
