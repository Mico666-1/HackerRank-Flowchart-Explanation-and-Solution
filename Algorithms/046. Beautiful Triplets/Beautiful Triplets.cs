using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'beautifulTriplets' function below.
     */
    public static int beautifulTriplets(int d, List<int> arr)
    {
        int count = 0;
        int n = arr.Count;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                if (arr[j] - arr[i] == d)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[k] - arr[j] == d)
                        {
                            count++;
                        }
                    }
                }
            }
        }

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
