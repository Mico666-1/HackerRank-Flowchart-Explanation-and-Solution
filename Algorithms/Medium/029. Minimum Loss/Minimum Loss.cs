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
     * Complete the 'minimumLoss' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts LONG_INTEGER_ARRAY price as parameter.
     */

    public static int minimumLoss(List<long> price)
    {
        Dictionary<long, int> indexMap = new Dictionary<long, int>();
        for (int i = 0; i < price.Count; i++)
            indexMap[price[i]] = i;

        List<long> sortedPrices = new List<long>(price);
        sortedPrices.Sort();

        long minLoss = long.MaxValue;

        for (int i = 1; i < sortedPrices.Count; i++)
        {
            long higher = sortedPrices[i];
            long lower = sortedPrices[i - 1];

            if (indexMap[higher] < indexMap[lower])
                minLoss = Math.Min(minLoss, higher - lower);
        }

        return (int)minLoss;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> price = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(priceTemp => Convert.ToInt64(priceTemp)).ToList();

        int result = Result.minimumLoss(price);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
