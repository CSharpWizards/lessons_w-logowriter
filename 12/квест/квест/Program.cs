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
            Console.WriteLine("Ты у входа в пещеру, которую охраняет орг. У тебя есть варианты действий:Вступаешь в бой ты отступаешь Подкупаешь огра Ищешь обходной путь ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1) 
            {
                Console.WriteLine("ты погибаешь, так как огр сильнее");
            }
            else if (option == 2)
            {
                Console.WriteLine("");
            }
            else if (option == 3)
            {
                Console.WriteLine("он пропускает тебя внутрь");
            }
            else
            {
                Console.WriteLine("по пути тебя грабят бандиты");
            }
            Console.ReadLine();

        }
    }
}
