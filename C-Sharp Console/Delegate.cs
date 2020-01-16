using System;
using System.Collections.Generic;

namespace C_Sharp_Console
{
    class Delegate
    {
        public delegate bool delegateFilter(int i);
        static bool lessThanFive(int n) { return n < 5; }
        static bool lessThanTen(int n) { return n < 10; }
        static bool greaterThanTen(int n) { return n > 10; }

        //#This number-filter takes a delegate as well as a list of numbers
        static IEnumerable<int> NumberFilter(IEnumerable<int> numbers, delegateFilter filter)
        {
            foreach (int num in numbers)
            {
                if (filter(num)) //#This line calls the delegate 
                {
                    yield return num;
                }
            }
        }

        public void RunDelegateProgram()
        {
            int[] numbers = new[] { 3, 3, 5, 6, 8, 2, 231, 6, 8, 8, 4, 2, 1, 8, 89 };

            //#will make a list from numbers which suffice the filter
            IEnumerable<int> result = NumberFilter(numbers, lessThanFive);

            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }

    }
}



