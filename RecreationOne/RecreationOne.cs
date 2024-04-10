using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecreationOne
{
    //needs refactor
    public class SumSquaredDivisors
    {
        public static string listSquared(long m, long n)
        {
            //your code
            //start at m
            //take each number
            //find the divisors
            //add squares of one and the number
            //use modulus to find other divisors upto half the number
            //square these numbers and add them to the original sum
            //finally, try to get their root

            //if they have a root
            //add the number that was being tested to an array at index 0
            //add the sum of the squares of the divisors of that number to index 1
            //repeat the process upto n and return all the arrays in an array

            string resultList = "[";
            bool l = false;

            long SquareSum(long x)
            {
                long squareSum = 0;

                for (long i = 1; i < x + 1; i++)
                {
                    if (x % i == 0)
                    {
                        squareSum += i * i;
                    }
                }
                //return squareSum;

                if (Math.Sqrt(squareSum) % 1 == 0)
                {
                    return squareSum;
                }
                else
                {
                    return 0;
                }
            }

            void Looper(long m, long n)
            {
                for (long i = m; i < n + 1; i++)
                {
                    long q = SquareSum(i);
                    if (q != 0)
                    {   
          
                        if(l == false) 
                        {
                            resultList += $"[{i}, {q}]";
                            l = true;
                        }
                        else
                        {
                            resultList += $", [{i}, {q}]";
                        }

                        
                        
                    }
                }
            };

            Looper(m, n);

            //Console.WriteLine($"{resultList}]");

            return $"{ resultList}]";
            //foreach (var item in resultList)
            //{
            //    foreach(var i in item)
            //    {
            //     Console.WriteLine(i);
            //    }
            //}

            //return String.Join("," ,resultList);
        }
    }
}
