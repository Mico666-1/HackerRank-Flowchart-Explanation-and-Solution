using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */

    public static int gemstones(List<string> arr)
    {
        // Initialize set with letters from the first rock
        HashSet<char> common = new HashSet<char>(arr[0]);

        // Intersect with letters from remaining rocks
        for (int i = 1; i < arr.Count; i++)
        {
            common.IntersectWith(arr[i]);
        }

        return common.Count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> arr = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string arrItem = Console.ReadLine();
            arr.Add(arrItem);
        }

        int result = Result.gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
