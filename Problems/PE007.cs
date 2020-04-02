using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE007
    {
        /*
         * Question: By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         * Answer: 104743
         * Notes: After reading about prime numbers in P3, I now know I only have to check for a prime number with other prime
         * numbers, and not every odd number. This is because some odd numbers such as 9 are products of other prime numbers.
         * Help: 
         */
        public static void P7()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int num = 1, count = 1, max = 10001; //start at 3 because every prime number after 2 is odd, so can +=2 for only odd.
            int[] primeCache = new int[max]; //keep track of prime numbers
            bool found;
            while (count < max)
            {
                found = true;
                num += 2;
                for (int i = 0; i < count-1; i++)
                {
                    if (primeCache[i] > Math.Sqrt(num)) break;
                    if (num % primeCache[i] == 0)
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    primeCache[count-1] = num;
                    count++;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(num);
        }

    }
}
