using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'chocolateFeast' function below.
     */
    public static int chocolateFeast(int n, int c, int m)
    {
        int chocolates = n / c; // buy chocolates with initial money
        int wrappers = chocolates; // initial wrappers

        while (wrappers >= m)
        {
            int extra = wrappers / m; // exchange wrappers for extra chocolates
            chocolates += extra;
            wrappers = wrappers % m + extra; // remaining wrappers + new chocolates wrappers
        }

        return chocolates;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int c = Convert.ToInt32(firstMultipleInput[1]);
            int m = Convert.ToInt32(firstMultipleInput[2]);

            int result = Result.chocolateFeast(n, c, m);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
