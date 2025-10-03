using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */
    public static List<int> permutationEquation(List<int> p)
    {
        int n = p.Count;
        List<int> result = new List<int>();

        for (int x = 1; x <= n; x++)
        {
            int firstIndex = p.IndexOf(x) + 1; // position of x
            int secondIndex = p.IndexOf(firstIndex) + 1; // position of firstIndex
            result.Add(secondIndex);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

        List<int> result = Result.permutationEquation(p);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
