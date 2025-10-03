using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'serviceLane' function below.
     */
    public static List<int> serviceLane(int n, List<List<int>> cases)
    {
        List<int> result = new List<int>();

        foreach (var c in cases)
        {
            int start = c[0];
            int end = c[1];
            int minWidth = int.MaxValue;

            for (int i = start; i <= end; i++)
            {
                minWidth = Math.Min(minWidth, n[i]);
            }

            result.Add(minWidth);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);

        List<int> width = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

        List<List<int>> cases = new List<List<int>>();

        for (int i = 0; i < t; i++)
        {
            cases.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
        }

        List<int> result = Result.serviceLane(width, cases);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
