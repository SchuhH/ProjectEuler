using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE005
    {
        /*
         * Question: 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         * Answer: 232792560
         * Notes: 
         * Help: 
         */
        public static void P5()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int num = 0;
            bool found = false;
            while (!found)
            {
                num+=20; //only numbers divisible by 20
                //all numbers not below 1-20 are a factor of the numbers below
                if (num % 11 != 0) continue;
                if (num % 12 != 0) continue;
                if (num % 13 != 0) continue;
                if (num % 14 != 0) continue;
                if (num % 15 != 0) continue;
                if (num % 16 != 0) continue;
                if (num % 17 != 0) continue;
                if (num % 18 != 0) continue;
                if (num % 19 != 0) continue;
                found = true;
            }

            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(num);
        }

    }
}
