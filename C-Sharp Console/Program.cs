using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C_Sharp_Console
{
    class Program
    {
        public delegate bool delegateFilter(int i);
        static bool lessThanfive(int n) { return n < 5; }
        static bool lessThanten(int n) { return n < 10; }
        static bool greaterThanTen(int n) { return n > 10; }


        static IEnumerable<int> NumberFilter(IEnumerable<int> numbers, delegateFilter filter)
        {
            foreach (int num in numbers)
            {
                if (filter(num))
                {
                    yield return num;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 3, 5, 6, 8, 2, 231, 6, 8, 8, 4, 2, 1, 8, 89 };
            IEnumerable<int> result = NumberFilter(numbers, lessThanFive);
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }                
            Console.ReadLine();
        }
    }
}
