using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'luckBalance' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. 2D_INTEGER_ARRAY contests
     */

    public static int luckBalance(int k, List<List<int>> contests)
    {
        List<int> important = new List<int>();
        int totalLuck = 0;

        foreach (var contest in contests)
        {
            int luck = contest[0];
            int importance = contest[1];

            if (importance == 1)
                important.Add(luck);
            else
                totalLuck += luck; // Unimportant contests can always be lost
        }

        important.Sort();
        int n = important.Count;

        for (int i = 0; i < n; i++)
        {
            if (i < n - k)
                totalLuck -= important[i]; // Must win these
            else
                totalLuck += important[i]; // Can lose these
        }

        return totalLuck;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> contests = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            contests.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(contestsTemp => Convert.ToInt32(contestsTemp)).ToList());
        }

        int result = Result.luckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
