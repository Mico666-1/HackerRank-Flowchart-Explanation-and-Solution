using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static long aVeryBigSum(List<long> ar)
    {
        return ar.Sum();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(long.Parse).ToList();

        long result = Result.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
