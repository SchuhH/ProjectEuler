using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.Problems
{
    static class BaseProblem
    {
        /*
         * Question: 
         * Answer:
         * Notes: 
         * Help: 
         */
        public static void Base()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var ans = 0;


            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds/1000}");
            Console.Write(ans);
        }

    }
}
