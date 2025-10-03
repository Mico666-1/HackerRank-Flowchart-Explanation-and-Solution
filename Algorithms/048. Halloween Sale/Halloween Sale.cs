using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Result
{
    /*
     * Complete the 'howManyGames' function below.
     */
    public static int howManyGames(int p, int d, int m, int s)
    {
        int count = 0;
        while (s >= p)
        {
            s -= p;
            count++;
            p = Math.Max(p - d, m);
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int p = Convert.ToInt32(firstMultipleInput[0]);
        int d = Convert.ToInt32(firstMultipleInput[1]);
        int m = Convert.ToInt32(firstMultipleInput[2]);
        int s = Convert.ToInt32(firstMultipleInput[3]);

        int answer = Result.howManyGames(p, d, m, s);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
