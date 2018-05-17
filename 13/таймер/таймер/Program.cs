using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("со старта программы прошло :");
            int second = 0;
            while (true)
            {
                Thread.Sleep(1000);
                second = second + 1;
                Console.WriteLine(second);
            }

        }
    }
}
