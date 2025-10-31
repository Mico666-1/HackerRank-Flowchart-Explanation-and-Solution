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
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
        int n = arr.Count;
        List<List<string>> buckets = new List<List<string>>();
        for (int i = 0; i < 100; i++)
        {
            buckets.Add(new List<string>());
        }

        for (int i = 0; i < n; i++)
        {
            int index = int.Parse(arr[i][0]);
            string value = i < n / 2 ? "-" : arr[i][1];
            buckets[index].Add(value);
        }

        List<string> result = new List<string>();
        foreach (var bucket in buckets)
        {
            result.AddRange(bucket);
        }

        Console.WriteLine(string.Join(" ", result));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}
