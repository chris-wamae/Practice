


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarrarySum
{
    public static class Kata
    {
        // * does not take continous arrays, instead just finds the numbers in the array that give the largest sum
        public static string MaxSequence(int[] arr)
        {
            List<int> maxList = new List<int>();
            List<int> currentList = new List<int>();

            int globalMax = 0;
            int maxUptoCurrentIndex = 0;
            int firstIndex = 0;
            int lastIndex = 0;
            bool firstIndexBool = false;
            string resultString = "";

            for (int x = 0; x < arr.Length; x++)
            {
                maxUptoCurrentIndex += arr[x];

                if (maxUptoCurrentIndex < arr[x] && x != arr.Length)
                {
                    maxUptoCurrentIndex = arr[x];
                }

                if (maxUptoCurrentIndex > globalMax)
                {
                    if (!firstIndexBool)
                    {
                        firstIndex = x;
                        firstIndexBool = true;
                    }
                    else
                    {
                        lastIndex = x;
                    }

                    globalMax = maxUptoCurrentIndex;

                    resultString = "";
                    for (int y = firstIndex; y < lastIndex; y++)
                    {
                        resultString += $"{arr[y]},";
                    }
                }
                ;
            }
            ;

            return $"[{resultString}[{globalMax}]]";
        }
    }
}

