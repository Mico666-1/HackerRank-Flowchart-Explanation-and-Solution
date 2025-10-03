using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aliceScore = 0;
        int bobScore = 0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                aliceScore++;
            else if (a[i] < b[i])
                bobScore++;
        }

        return new List<int> { aliceScore, bobScore };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
