using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'equalizeArray' function below.
     */
    public static int equalizeArray(List<int> arr)
    {
        var freq = new Dictionary<int, int>();

        foreach (var num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        int maxFreq = freq.Values.Max();

        return arr.Count - maxFreq;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
