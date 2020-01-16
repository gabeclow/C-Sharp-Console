using System;
using System.Threading;

namespace C_Sharp_Console
{
    class Threading
    {
        public delegate void CallTwo();

        private void delegateCallThreadTwo(CallTwo callTwo)
        {
            callTwo();
        }

        public void SimilarCall()
        {
            delegateCallThreadTwo(ThreadTwoFact);
            delegateCallThreadTwo(ThreadTwoFactPlusTen);
            delegateCallThreadTwo(ThreadThree);
            delegateCallThreadTwo(ThreadThree2);
        }

        //#calculates factorial of a number via recursion
        private double ThreadOneFactorial(int n)
        {
            double result = n;
            if (n <= 1)
            {
                return n;
            }
            return result *= ThreadOneFactorial(n - 1);
        }

        private static object syncLock = new object();

        private void ThreadTwoFact()
        {
            lock (syncLock)
            {
                double factorialResult = ThreadOneFactorial(5);
                Console.WriteLine(factorialResult);
            }
        }
        
        private void ThreadTwoFactPlusTen()
        {
            lock (syncLock)
            {
                double factorialResult = ThreadOneFactorial(5) + 10;
                Console.WriteLine(factorialResult);
            }
        }

        private void ThreadThree()
        {
            for(int i = 0; i < 100; i++)
            {
                int j = i % 10;
                Console.WriteLine(i);
            }
        }
        private void ThreadThree2()
        {
            for (int i = 0; i < 100; i++)
            {
                int j = i % 10;
                Console.WriteLine(i);
            }
        }

    }
}
