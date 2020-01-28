using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console
{
    public class RecursiveFunctions
    {
        
        //returns the element value at index
        public int fibonacci(int index)
        {
            if(index <= 2)
            {
                return 1;
            }
            else
            {
            return fibonacci(index - 2) + fibonacci(index - 1);
            }
        }

        //prints down to 1 from N in the console window.
        public void printNnaturalNumbers(int n)
        {
            if(n < 2)
            {
                Console.WriteLine(n.ToString());
                n--;
            }
            else
            {
                Console.WriteLine(n.ToString());
                n = n - 1;
                printNnaturalNumbers(n);
            }
        }

        //prints up to N in the console window.
        public void printUpToNnaturalNumbers(int n, int index = 1)
        {
            if (index == n)
            {
                Console.WriteLine(index.ToString());
            }
            else
            {
                Console.WriteLine(index.ToString());
                index++;
                printUpToNnaturalNumbers(n, index);
            }
        }

        //display the individual digits of a given number using recursion
        public void showIndividualDigits(int n)
        {
            Console.WriteLine(n.ToString()[0]);
            try
            {
                showIndividualDigits(Convert.ToInt32(n.ToString().Substring(1)));
            }
            catch (Exception) { }
        }

        //count the number of digits in a number using recursion
        public void countDigits(int n, int counter = 1)
        {
            try
            {
                n = n / 10;
                if (n > 0)
                {
                    counter++;
                    countDigits(n, counter);
                }
                else
                {
                    Console.WriteLine(counter.ToString());
                }
            }
            catch (Exception) { }
        }

        //print even or odd numbers in a given range using recursion
        public void printOddOrEvenInRange(int min, int max, byte oddOrEven)
        {
            switch (oddOrEven)
            {
                case 0:
                    if (min % 2 != 0)
                    {
                        min++;
                    }
                    break;
                case 1:
                    if (min % 2 == 0)
                    {
                        min++;
                    }
                    break;
                default: break;
            }
            
            if(min <= max)
            {
                Console.WriteLine(min);
                printOddOrEvenInRange(min+2, max, oddOrEven);
            }
        }

       
        




    }
}
