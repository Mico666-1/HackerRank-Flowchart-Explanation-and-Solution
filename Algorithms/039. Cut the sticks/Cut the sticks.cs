using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'cutTheSticks' function below.
     */
    public static List<int> cutTheSticks(List<int> arr)
    {
        List<int> result = new List<int>();
        while (arr.Count > 0)
        {
            result.Add(arr.Count);
            int min = arr.Min();
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] -= min;
            }
            arr = arr.Where(x => x > 0).ToList();
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.cutTheSticks(arr);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
