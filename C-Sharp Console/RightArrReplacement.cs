using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console
{
    class RightArrReplacement
    {

        private int[] iArray = new int[] { 17, 18, 5, 4, 6, 1 };

        private int[] ReplaceElements(int[] arr)
        {
            int totalArraySize = arr.Count() - 1;
            for (int i = 0; i < totalArraySize+1; i++) //#go left to right through array
            {
                if (i == arr.Count() - 1)
                {
                    arr[i] = -1;
                }
                else
                {
                    int largestSoFar = 0;
                    
                    for(int j=i; j < totalArraySize; j++)
                    {
                        int num = arr[j+1];
                        largestSoFar = (num > largestSoFar) ? num : largestSoFar;
                        arr[i] = largestSoFar;
                    }
                }
            }
            return arr;
        }

        public void Solve_iArray()
        {
            //# Expected Output: [18,6,6,6,1,-1]
            int[] intArray = ReplaceElements(iArray);
            foreach(int number in intArray)
            {
                Console.WriteLine(number);
            }
        } 

    }
}
