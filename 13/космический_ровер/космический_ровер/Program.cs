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
            Console.WriteLine("ты управляешь космическим исследовательским ровером. Если в составе воздуха больше 20%кислорода и средняя температура выше 15°C, то он отправлет на Землю сообщение, что планета пригодна для заселения, иначе — что непригодна");
            int oxygen = int.Parse(Console.ReadLine());
            int temperature = int.Parse(Console.ReadLine());
            if (oxygen > 20 && temperature > 15)
            {
                Console.WriteLine("планета пригодна");
            }
            else
            {
                Console.WriteLine("планета не пригодна для заселения !!!");
            }
            Console.ReadLine();
        }
    }
}
