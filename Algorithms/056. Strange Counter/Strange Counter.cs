using System;
using System.IO;

class Result
{
    /*
     * Complete the 'strangeCounter' function below.
     */
    public static long strangeCounter(long t)
    {
        long start = 1;
        long value = 3;

        while (t > start + value - 1)
        {
            start += value;
            value *= 2;
        }

        return value - (t - start);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.strangeCounter(t);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
