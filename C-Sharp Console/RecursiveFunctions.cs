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



        


    }
}
