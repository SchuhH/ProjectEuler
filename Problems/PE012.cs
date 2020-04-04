﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE012
    {
        /*
         * Question: The sequence of triangle numbers is generated by adding the natural numbers. 
         * So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
         * 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
         * Let us list the factors of the first seven triangle numbers:
         * 1: 1
         * 3: 1,3
         * 6: 1,2,3,6
         * 10: 1,2,5,10
         * 15: 1,3,5,15
         * 21: 1,3,7,21
         * 28: 1,2,4,7,14,28
         * We can see that 28 is the first triangle number to have over five divisors.
         * What is the value of the first triangle number to have over five hundred divisors?
         * Answer: 76576500
         * Notes: 
         * Help: 
         */
        public static void P12()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int num = 0, naturalNumber=0, divisors;
            while (true)
            {
                num++;
                naturalNumber += num;
                divisors = 0;
                for (int i = 1; i < Math.Sqrt(naturalNumber); i++)
                {
                    if (naturalNumber % i == 0)
                    {
                        divisors += 2;
                    }
                }
                if (Math.Pow(naturalNumber, 2) == Math.Sqrt(naturalNumber))
                {
                    divisors--;
                }
                if (divisors > 499)
                {
                    break;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(naturalNumber);
        }

    }
}