using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'fairRations' function below.
     */
    public static string fairRations(List<int> B)
    {
        int loafsGiven = 0;

        for (int i = 0; i < B.Count - 1; i++)
        {
            if (B[i] % 2 != 0)
            {
                B[i]++;
                B[i + 1]++;
                loafsGiven += 2;
            }
        }

        if (B[B.Count - 1] % 2 != 0)
        {
            return "NO";
        }

        return loafsGiven.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

        string result = Result.fairRations(B);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
