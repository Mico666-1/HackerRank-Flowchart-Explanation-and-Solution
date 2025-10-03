using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'insertionSort1' function below.
     */
    public static void insertionSort1(int n, List<int> arr)
    {
        int key = arr[n - 1];
        int i = n - 2;

        while (i >= 0 && arr[i] > key)
        {
            arr[i + 1] = arr[i];
            Console.WriteLine(string.Join(" ", arr));
            i--;
        }

        arr[i + 1] = key;
        Console.WriteLine(string.Join(" ", arr));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
