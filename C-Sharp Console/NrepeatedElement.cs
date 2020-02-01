using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console
{
    public class NrepeatedElement
    {
        private static int[] array = new int[] { 5, 1, 5, 2, 5, 3, 5, 4 };
        private static int[] array2 = new int[] { 1, 2, 3, 3 };

        private static int RepeatedNTimesNaive(int[] A)//# naive approach
        {
            int result = -1;
            for(int i=0; i<A.Length; i++)//#loop through array
            {
                int currentNumber = A[i];
                for(int j = 0; j < A.Length; j++)
                {
                    if (A[j] == currentNumber && j!=i)
                    {
                        result = A[j];
                    }
                }
            }
            return result;
        }

        private static int RepeatedNTimesDictionary(int[] Array) //# Faster than Naive approach
        {
            int result = -1;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for(int i=0; i<Array.Length; i++)
            {
                if (dictionary.ContainsKey(Array[i]))
                {
                    result = Array[i];
                    break;
                }
                else
                {
                    dictionary.Add(Array[i], 1);
                }
            }
            return result;
        }


        public int RepeatedDictionary(int[] Array)
        {
            return RepeatedNTimesDictionary(Array);
        }

        public int RepeatedNaive(int[] Array)
        {
            return RepeatedNTimesNaive(Array);
        }

    }
}
