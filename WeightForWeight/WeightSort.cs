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
            // your code
            //split the string along white spaces
            //create a copy of this array but with its numbers being number weight(add the numbers)
            //order the numbers in the old array how the numbers in the new array would be if arranged
            //in ascending order
            //if numbers in the new array are equal, refer to their old array values and use that to arrange
            //them
            //return the old array as a string arranged how the new array would be arranged

            string[] rawArray = strng.Split(' ');

            int[][] rawNumPlusSumArray = new int[rawArray.Length][];

            int GetTotal(int n)
            {
                if (n < 10)
                    return n;
                return GetTotal(n / 10) + n % 10;
            }

            for (int i = 0; i < rawArray.Length; i++)
            {
                rawNumPlusSumArray[i] = new int[2]
                {
                    Convert.ToInt32(rawArray[i]),
                    GetTotal(Convert.ToInt32(rawArray[i]))
                };
            }

            void Sorter(int[][] a)
            {

                for (int i = 0; i < a.Length - 1; i++)
                    // traverse i+1 to array length
                    for (int j = i + 1; j < a.Length; j++)

                        // compare array element with 
                        // all next element
                        if (a[i][1] < a[j][1])
                        {
                            (a[j], a[i]) = (a[i], a[j]);
                        }
            }

            Sorter(rawNumPlusSumArray);

            foreach (var item in rawNumPlusSumArray)
            {
                Console.WriteLine(item[0]);
            }

            return "";
             
        }
    }
}
