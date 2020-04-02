using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class PE004
    {
        /*
         * Question: A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit 
         * numbers is 9009 = 91 × 99.
         * Find the largest palindrome made from the product of two 3-digit numbers.
         * Answer: 906609
         * Notes: 
         * Help: 
         */
        public static void P4()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int nDigits = 3;
            int upperbound = (int)Math.Pow(10, nDigits) - 1, lowerbound = upperbound / 10;
            ulong maxPal = (ulong)Math.Pow(upperbound, 2), minPal = (ulong)Math.Pow(lowerbound + 2, 2), pal=0;
            int upperHalf = Convert.ToInt32(maxPal.ToString().Remove(maxPal.ToString().Length / 2));
            int lowerHalf = Convert.ToInt32(minPal.ToString().Remove(minPal.ToString().Length / 2));
            bool foundpal = false;
            for (int i = upperHalf; i > lowerHalf; i--)
            {
                pal = Convert.ToUInt64(i.ToString() + new string(i.ToString().ToCharArray().Reverse().ToArray()));
                if (pal > maxPal)
                {
                    continue;
                }
                if (pal < minPal)
                /*
                 * this fixes the possibility of the algorithm testing pals which are impossible, ex:
                 * for nDigits=3, a pal of 1001 would be created, which is impossible because two 2 digit
                 * numbers cannot create this, so it will put a number in the middle and test all odd # possibilities
                 */
                {
                    string palString = pal.ToString();
                    for (int k = 0; k < 10; k++)
                    {
                        pal = Convert.ToUInt64(palString.Insert(palString.Length / 2, k.ToString()));
                        FindPal(ref upperbound, ref lowerbound, pal, ref foundpal);
                    }
                }
                FindPal(ref upperbound, ref lowerbound, pal, ref foundpal);
                if (foundpal)
                {
                    break;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");

            Console.WriteLine(pal);

        }
        //decided to make this its own method so testing when pal<minpal does not reuse code
        private static void FindPal(ref int upperbound, ref int lowerbound, ulong pal, ref bool foundpal)
        {
            for (int j = upperbound; j > lowerbound; j--)
            {
                if ((ulong)j * (ulong)j < pal) //otherwise it will give a pal, which has a factor not nDigits 
                {
                    break;
                }
                if (pal % (ulong)j == 0) //see if it is divisible, if so then it is the pal
                {
                    foundpal = true;
                    break;
                }
            }
        }
    }
}
