using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightForWeight
{
    public class WeightSort
    {
        public static string orderWeight(string strng)
        {
            if (strng == "")
            {
                return "";
            }

            string[] rawArray = strng.Split(' ');

            long[][] rawNumPlusSumArray = new long[rawArray.Length][];

            long GetTotal(long n)
            {
                if (n < 10)
                    return n;
                return GetTotal(n / 10) + n % 10;
            }

            // Convert strings to long integers and compute their sums
            for (int i = 0; i < rawArray.Length; i++)
            {
                long num;
                if (long.TryParse(rawArray[i], out num))
                {
                    rawNumPlusSumArray[i] = new long[2]
                    {
                num,
                GetTotal(num)
                    };
                }
                else
                {
                    // Handle invalid input (non-numeric strings)
                    // Here, I'm assigning a sum of -1 to represent invalid input
                    rawNumPlusSumArray[i] = new long[2] { num, -1 };
                }
            }

            // Sort the array based on sum and then based on the original number
            void Sorter(long[][] a)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i][1] > a[j][1] || (a[i][1] == a[j][1] && a[i][0].ToString().CompareTo(a[j][0].ToString()) > 0))
                        {
                            (a[j], a[i]) = (a[i], a[j]);
                        }
                    }
                }
            }

            Sorter(rawNumPlusSumArray);

            // Extract the sorted numbers from the array
            long[] arr = new long[rawNumPlusSumArray.Length];
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rawNumPlusSumArray[x][0];
            }

            return string.Join(" ", arr);
        }
    }
}
