using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'minimumDistances' function below.
     */
    public static int minimumDistances(List<int> a)
    {
        int minDistance = int.MaxValue;
        int n = a.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    int distance = j - i;
                    if (distance < minDistance)
                        minDistance = distance;
                }
            }
        }

        return (minDistance == int.MaxValue) ? -1 : minDistance;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
