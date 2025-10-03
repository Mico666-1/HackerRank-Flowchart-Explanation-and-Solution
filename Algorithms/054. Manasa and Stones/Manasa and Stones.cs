using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'stones' function below.
     */
    public static List<int> stones(int n, int a, int b)
    {
        SortedSet<int> results = new SortedSet<int>();

        for (int i = 0; i < n; i++)
        {
            int lastStone = a * (n - 1 - i) + b * i;
            results.Add(lastStone);
        }

        return results.ToList();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int a = Convert.ToInt32(Console.ReadLine().Trim());
            int b = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> result = Result.stones(n, a, b);

            textWriter.WriteLine(String.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
