using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace C_Sharp_Console
{
    class Program
    {

        static void Main(string[] args)
        {
            RecursiveFunctions recursive = new RecursiveFunctions();
            List<int> list = recursive.Fib(100);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

    }
}
