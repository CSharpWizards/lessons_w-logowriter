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
            Console.WriteLine("бей дракона. Ты начинающий рыцарь и можешь одолеть дракона, только если он молодой  (младше 150 лет) или сильно ранен (количество здоровья меньше 50 из 100). Введите здоровье дракона Введите вoзраст дракона");
            int xp = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            if (xp < 50 || age < 150)
            {
                Console.WriteLine("попытайте в бою удачу");
            }
            else
            {
                Console.WriteLine("лучше не стоит !!!");
            }
            Console.ReadLine();
        }
    }
}
