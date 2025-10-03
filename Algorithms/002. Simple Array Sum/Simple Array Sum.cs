using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int simpleArraySum(List<int> ar)
    {
        // Return the sum of all elements in the list
        return ar.Sum();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
