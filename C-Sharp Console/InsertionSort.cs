using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console
{
    class InsertionSort
    {
        private static int[] numberArray = new int[] { 7,4,5,2 };

        private static int[] insertion_sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                /*storing current element whose left side is checked for its 
                         correct position .*/
                int temp = array[i];
                int j = i;
                /* check whether the adjacent element in left side is greater or
                     less than the current element. */

                while (j > 0 && temp < array[j - 1])
                {

                    // moving the left side element to one position forward.
                    array[j] = array[j - 1];
                    j = j - 1;

                }
                // moving current element to its  correct position.
                array[j] = temp;
            }
            return array;
        }

        public static void printInsertionSort()
        {
            Console.Write("Before Sort: ");
            foreach(int num in numberArray)
            {
                Console.Write(num.ToString() + " ");
            }
            Console.WriteLine("");
            int[] afterArray = insertion_sort(numberArray);
            Console.Write("After Sort: ");
            foreach (int num in afterArray)
            {
                Console.Write(num.ToString() + " ");
            }
        } 


    }
}
