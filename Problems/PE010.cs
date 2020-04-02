using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE010
    {
        /*
         * Question: The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
         * Find the sum of all the primes below two million.
         * Answer: 142913828922
         * Notes: Forgot about checking over sqrt is pointless, had to fix, was taking too long. Going over sqrt pointless
         * because if it divisible by a number, it would have been divisible by its sqrt.
         * Help: 
         */
        public static void P10()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int> primeList = new List<int>(0);
            ulong sum = 2, count = 0; //don't add 2 to list, because no other even prime numbers, so no need to check
            bool found;

            for (int i = 3; i < 2000001; i += 2)
            {
                found = true;
                for (int j = 0; j < primeList.Count(); j++)
                {
                    if (primeList[j] > Math.Sqrt(i)) break;
                    if (i % primeList[j] == 0)
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    primeList.Add(i);
                    sum += (ulong)i;
                    count++;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(sum);

        }

    }
}
