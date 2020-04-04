using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace ProjectEuler.Problems
{
    static class PE013
    {
        /*
         * Question: string of ints, 100 lines, 50 digits per line, add them together and print first 10 digits
         * Answer: 5537376230
         * Notes: 
         * Help: 
         */
        public static void P13()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[,] intArr = new int[100,50];
            CreateIntArr(ref intArr);
            List<int> myInt = new List<int>(50); //linked list should have been used instead
            for (int i = 0; i<50; i++)
            {
                myInt.Add(0);
            }
            int remainder;
            string ans = "";
            for (int i = 0; i<100; i++)
            {
                remainder = 0;
                for (int j = 49; j>=0; j--)
                {
                    myInt[j] += intArr[i, j] + remainder;
                    if (myInt[j] < 10)
                    {
                        remainder = 0;
                        continue;
                    }
                    if (myInt[j] > 9)
                    {
                        myInt[j] -= 10;
                        remainder = 1;
                    }
                }
                if (remainder == 1)
                {
                    myInt[0]+=10; //initial value can expand the remainder instead of inserting a new value into the beginning of the list
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"The elapsed time is: {(double)stopwatch.ElapsedMilliseconds / 1000}");
            for (int i = 0; i<11-myInt[0].ToString().Length; i++)
            {
                ans += myInt[i].ToString();
            }
            Console.WriteLine(ans);
        }
        private static void CreateIntArr(ref int[,] intArr)
        {
            string[] stringLine = System.IO.File.ReadAllLines(@"PE013.txt");
            int count = 0;
            foreach(string line in stringLine)
            {
                for (int i = 0; i < 50; i++)
                {
                    intArr[count, i] = (int)Char.GetNumericValue(line[i]);
                }
                count++;
            }
        }
    }
}
