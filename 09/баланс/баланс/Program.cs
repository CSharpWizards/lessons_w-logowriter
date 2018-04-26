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
            Console.WriteLine("введите номер игры, которую хотите купить");
            Console.WriteLine("1 - GTA V");
            Console.WriteLine("2 - NFS 51");
            Console.WriteLine("3 - StarCraft");
            int game = int.Parse(Console.ReadLine());
            int gamePrice;
            if (game == 1)
            {
                gamePrice = 380; 
            }
            if (game == 2)
            {
                gamePrice = 170;
            }
            if (game == 3)
            {
                gamePrice = 230;
            }
            Console.WriteLine("введите балланс на своем телефоне");
            double balance = double.Parse(Console.ReadLine());
            gamePrice = 170;
            gamePrice = 230;
            if (balance > gamePrice)
            {
                Console.WriteLine("поздравляем с покупкой игра скоро закачается");
            }
            else
            {
                Console.WriteLine("у вас не хватает денег ");
            }
            Console.ReadLine();
        }
    }
}
