using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int primarySum = 0;
        int secondarySum = 0;
        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            primarySum += arr[i][i];
            secondarySum += arr[i][n - 1 - i];
        }

        return Math.Abs(primarySum - secondarySum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
