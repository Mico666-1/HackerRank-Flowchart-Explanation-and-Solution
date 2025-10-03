using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        int maxLength = 0;
        var freq = new Dictionary<int, int>();

        // Count frequency of each number
        foreach (int num in a)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }

        // Check max length by comparing num with num+1
        foreach (var key in freq.Keys)
        {
            int count = freq[key];
            if (freq.ContainsKey(key + 1))
                count += freq[key + 1];
            if (count > maxLength)
                maxLength = count;
        }

        return maxLength;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
