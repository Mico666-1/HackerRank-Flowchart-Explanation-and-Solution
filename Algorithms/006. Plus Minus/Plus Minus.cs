using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static void plusMinus(List<int> arr)
    {
        int countPositive = 0;
        int countNegative = 0;
        int countZero = 0;
        int total = arr.Count;

        foreach (int num in arr)
        {
            if (num > 0) countPositive++;
            else if (num < 0) countNegative++;
            else countZero++;
        }

        Console.WriteLine(((double)countPositive / total).ToString("F6"));
        Console.WriteLine(((double)countNegative / total).ToString("F6"));
        Console.WriteLine(((double)countZero / total).ToString("F6"));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        Result.plusMinus(arr);
    }
}
