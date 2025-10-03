using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'jumpingOnClouds' function below.
     */
    public static int jumpingOnClouds(List<int> c)
    {
        int jumps = 0;
        int i = 0;

        while (i < c.Count - 1)
        {
            if (i + 2 < c.Count && c[i + 2] == 0)
                i += 2;
            else
                i += 1;

            jumps++;
        }

        return jumps;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
