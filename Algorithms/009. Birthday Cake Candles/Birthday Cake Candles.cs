using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxHeight = candles.Max();
        int count = candles.Count(c => c == maxHeight);
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
