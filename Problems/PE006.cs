using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE006
    {
        /*
         * Question: The sum of the squares of the first ten natural numbers is, 1+4+...+100=385
         * The square of the sum of the first ten natural numbers is, (1+2+...+10)^2=552=3025
         * Hence the difference between the sum of the squares of the first ten natural numbers and the square 
         * of the sum is 3025−385=2640. Find the difference between the sum of the squares of the first one 
         * hundred natural numbers and the square of the sum.
         * Answer: 25164150
         * Notes: 
         * Help: 
         */
        public static void P6()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sumSq = 0, sqSum, sum, ans, num =10000000;
            for (int i = 1; i < num+1; i++)
            {
                sumSq += (int)Math.Pow(i, 2);
            }
            sum = num * (num + 1) / 2;
            sqSum = (int)Math.Pow(sum, 2);
            ans = sqSum - sumSq;
            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(ans);
        }

    }
}
