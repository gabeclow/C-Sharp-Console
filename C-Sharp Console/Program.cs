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
            recursive.printNnaturalNumbers(20);
            Console.Read();
        }



    }
}
