using System;
using System.IO;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'stringConstruction' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int stringConstruction(string s)
    {
        bool[] seen = new bool[26];
        int cost = 0;

        foreach (char c in s)
        {
            if (!seen[c - 'a'])
            {
                cost++;
                seen[c - 'a'] = true;
            }
        }

        return cost;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.stringConstruction(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
