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
            recursive.printOddOrEvenInRange(1, 5000,1);
            Console.Read();
        }



    }
}
