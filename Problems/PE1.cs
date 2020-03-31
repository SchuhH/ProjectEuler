using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler.Problems
{
    static class PE1
    {
        /*
         * Question: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         * Find the sum of all the multiples of 3 or 5 below 1000.
         * Answer: 233168
         * Execution time: 0
         * Notes: I know of the arithmetic sum way to solve, but it would not be the first thing to come to mind, so it will not be my final solution
         * Help: 
         */
        public static void P1()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int ans = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    ans += i;
                }
            }
            
            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(ans);
            
            /*
            * int sum1 = 0;
            *sum1 += (3 * (999 / 3) * ((999 / 3) + 1) / 2);
            *sum1 += (5 * (999 / 5) * ((999 / 5) + 1) / 2);
            *sum1 -= (15 * (999 / 15) * ((999 / 15) + 1) / 2);
            *Console.WriteLine(sum1);
            */
        }
    }
}
