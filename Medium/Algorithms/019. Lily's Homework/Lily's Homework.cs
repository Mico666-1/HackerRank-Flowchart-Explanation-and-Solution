using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'lilysHomework' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int lilysHomework(List<int> arr)
    {
        return Math.Min(GetMinSwaps(arr, false), GetMinSwaps(arr, true));
    }

    private static int GetMinSwaps(List<int> arr, bool reverse)
    {
        int n = arr.Count;
        List<int> sorted = reverse ? arr.OrderByDescending(x => x).ToList() : arr.OrderBy(x => x).ToList();
        Dictionary<int, int> indexMap = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
            indexMap[arr[i]] = i;

        int swaps = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != sorted[i])
            {
                swaps++;

                int currentVal = arr[i];
                int correctVal = sorted[i];

                int swapIndex = indexMap[correctVal];

                // Swap
                arr[i] = correctVal;
                arr[swapIndex] = currentVal;

                // Update map
                indexMap[currentVal] = swapIndex;
                indexMap[correctVal] = i;
            }
        }

        return swaps;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.lilysHomework(arr);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
