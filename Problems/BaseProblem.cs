using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler.Problems
{
    static class BaseProblem
    {
        /*
         * Question: 
         * Answer:
         * Execution time: 
         * Notes: 
         * Help: 
         */
        public static void Base()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();



            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds/1000}");
            Console.Write(1);
        }

    }
}
