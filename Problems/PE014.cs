using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE014
    {
        /*
         * Question: The following iterative sequence is defined for the set of positive integers:
         * n → n/2 (n is even)
         * n → 3n + 1 (n is odd)
         * Using the rule above and starting with 13, we generate the following sequence:
         * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
         * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been
         * proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
         * Which starting number, under one million, produces the longest chain?
         * Answer: 837799
         * Notes: 
         * Help: 
         */
        public static void P14()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int ans, chainLength, greatestChainLength = 1, gclNumber = 1;
            ulong num;
            int[] cache = new int[1000000];
            cache[0] = 1;
            List<int> numsSaved = new List<int>() ;
            for (int i = 2; i < 1000000; i++)
            {
                numsSaved.Clear(); // I don't make a new list because it's only going to grow over time, so why keep changing the size?
                num = (ulong)i;
                chainLength = 0;
                while (true)
                {
                    if (num < 1000000)
                    {
                        if (cache[num-1] == 0)
                        {
                            cache[num - 1] = chainLength;
                            numsSaved.Add((int)num - 1);
                        }
                        else
                        {
                            chainLength += cache[num-1];
                            break;
                        }
                    }
                    if (num % 2 == 0)
                    {
                        num /= 2;
                    }
                    else
                    {
                        num = (num * 3) + 1;
                    }
                    chainLength++;
                }
                foreach (int x in numsSaved)
                {
                    cache[x] = chainLength - cache[x];
                }
                if (chainLength > greatestChainLength)
                {
                    greatestChainLength = chainLength;
                    gclNumber = i;
                }
            }
            ans = gclNumber;
            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.WriteLine(ans);
        }
    }
}
