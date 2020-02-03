using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console
{
    public class SelfDividingNumbers
    {

        //Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
        public List<int> selfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for(int number=left; number <= right; number++)//get every whole number in given range 
            {
                int[] array = digitArr(number);
                bool flag = true;
                for(int i=0; i<array.Length;i++)//each digit in number
                {
                    int arrayNum = array[i];
                    try
                    {
                        if (number % arrayNum != 0)
                        {
                            flag = false;
                        }
                    }
                    catch (Exception) { flag=false; continue; }
                }
                if (flag) result.Add(number);

            }
            return result;
        }

        private static int[] digitArr(int n)
        {
            if (n == 0) return new int[1] { 0 };

            var digits = new List<int>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }


    }
}
