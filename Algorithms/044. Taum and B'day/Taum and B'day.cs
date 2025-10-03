using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    /*
     * Complete the 'taumBday' function below.
     */
    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        long costBlack = bc;
        long costWhite = wc;

        if (bc > wc + z)
            costBlack = wc + z;
        if (wc > bc + z)
            costWhite = bc + z;

        long totalCost = (long)b * costBlack + (long)w * costWhite;
        return totalCost;
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

            int b = Convert.ToInt32(firstMultipleInput[0]);

            int w = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int bc = Convert.ToInt32(secondMultipleInput[0]);

            int wc = Convert.ToInt32(secondMultipleInput[1]);

            int z = Convert.ToInt32(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
