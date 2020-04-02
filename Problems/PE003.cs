using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler.Problems
{
    static class PE003
    {
        /*
         * Question: The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143?
         * Answer: 6857
         * Notes: was hard because was unsure how to solve for answers > sqrt
         * Help: https://www.mathblog.dk/project-euler-problem-3/, the idea of the sqrt being less then the ans
         */
        public static void P3()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ulong ans = 0, want = 600851475143;
            ulong startPoint = (ulong)Math.Sqrt(want); //sqrt for the startpoint because otherwise you will be repeating
            for (ulong i = startPoint; i>1; i--)
            {
                if (want%i==0) //for numbers like 28 or 33 where sqrt(n) is < the highest prime factor.
                {              //ex: sqrt(28)=5, when 7 is the highest prime factor.
                    if (IsPrime(want / i))
                    {
                        ans = want / i;
                        break;
                    }
                }
                if (IsPrime(i))
                {
                    if (want%i==0)
                    {
                        ans = i;
                        break;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            Console.Write(ans);
        }
        static bool IsPrime(ulong n)
        {
            if (n % 2 == 0)
            {
                return false;
            }
            for (ulong j = 3; j <= Math.Sqrt(n); j += 2)
            {
                if (n % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
