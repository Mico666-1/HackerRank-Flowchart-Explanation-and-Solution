using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        long totalSum = arr.Sum(i => (long)i);  // Use long to avoid overflow
        int minVal = arr.Min();
        int maxVal = arr.Max();

        long minSum = totalSum - maxVal;
        long maxSum = totalSum - minVal;

        Console.WriteLine($"{minSum} {maxSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        Result.miniMaxSum(arr);
    }
}
