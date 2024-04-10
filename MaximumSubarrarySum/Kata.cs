using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarrarySum
{
    //needs refactor


    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            int arrLength = arr.Length;
            if (arrLength == 0)
            {
                return 0;
            }
            int max = 0;
            int currentDigitsCount = 2;

            //error in tests
            //might not be checking the final array, ie. the whole array

            //review the condition of this while loop
            while (currentDigitsCount < arrLength + 1)
            {
                for (int i = 0; i < arrLength - (currentDigitsCount - 1); i++)
                {
                    int localCount = currentDigitsCount;
                    int localSum = 0;
                    int localIndex = i;

                    //review the condition of this while loop
                    while (localCount != 0)
                    {
                        localSum += arr[localIndex];
                        localIndex++;
                        localCount--;
                    }

                    if (localSum > max)
                    {
                        max = localSum;
                    }
                }

                currentDigitsCount++;
            }
            //Console.WriteLine(max);
            if (max < 0)
            {
                return 0;
            }
            ;
            return max;
        }
    }
}
