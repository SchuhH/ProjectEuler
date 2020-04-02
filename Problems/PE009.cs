using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE009
    {
        /*
         * Question: A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2 + b^2 = c^2
         * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
         * There exists exactly one Pythagorean triplet for which a + b + c = 1000
         * Find the product abc.
         * Answer: 31875000
         * Notes: 
         * Help: 
         */
        public static void P9()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int a, b, c, sqrtA, sqrtB, sqrtC, sum, product = 0;
            bool found = false;
            int[] sqrs = new int[500];
            for (int i = 1; i < 500; i++) //can't go above 500, because otherwise a+b>500, and no room for c
            {
                sqrs[i-1] = (int)Math.Pow(i, 2);
            }

            for (int i = 0; i < 500; i++) 
            {
                a = sqrs[i];
                for (int j = 0; j < 500; j++)
                {
                    b = sqrs[j];
                    c = a + b;
                    sqrtA = (int)Math.Sqrt(a);
                    sqrtB = (int)Math.Sqrt(b);
                    sqrtC = (int)Math.Sqrt(c);
                    sum = sqrtA + sqrtB + sqrtC;
                    Console.WriteLine(sum);
                    if (sum > 1000) break;
                    if (Math.Sqrt(c) % 1 != 0) continue;
                    if (sum == 1000)
                    {
                        product = sqrtA * sqrtB * sqrtC;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(product);
        }

    }
}
