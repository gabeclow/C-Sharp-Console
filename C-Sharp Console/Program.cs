﻿using System;
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
            SelfDividingNumbers self = new SelfDividingNumbers();
            self.selfDividingNumbers(1, 22);
            Console.Read();
        }

    }
}
