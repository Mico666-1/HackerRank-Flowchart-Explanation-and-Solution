using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'jimOrders' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY orders as parameter.
     */

    public static List<int> jimOrders(List<List<int>> orders)
    {
        int n = orders.Count;
        List<(int finishTime, int index)> finishTimes = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            int orderTime = orders[i][0];
            int prepTime = orders[i][1];
            finishTimes.Add((orderTime + prepTime, i + 1)); // i+1 because order indices are 1-based
        }

        finishTimes.Sort((a, b) =>
        {
            int cmp = a.finishTime.CompareTo(b.finishTime);
            return cmp != 0 ? cmp : a.index.CompareTo(b.index);
        });

        return finishTimes.Select(x => x.index).ToList();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> orders = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            orders.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ordersTemp => Convert.ToInt32(ordersTemp)).ToList());
        }

        List<int> result = Result.jimOrders(orders);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
