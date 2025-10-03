using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'happyLadybugs' function below.
     */
    public static string happyLadybugs(string b)
    {
        if (b.Length == 1)
            return b == "_" ? "YES" : "NO";

        Dictionary<char, int> counts = new Dictionary<char, int>();
        foreach (char c in b)
        {
            if (c != '_')
            {
                if (!counts.ContainsKey(c))
                    counts[c] = 0;
                counts[c]++;
            }
        }

        foreach (var kvp in counts)
        {
            if (kvp.Value == 1)
                return "NO";
        }

        if (!b.Contains('_'))
        {
            for (int i = 0; i < b.Length; i++)
            {
                if ((i == 0 || b[i] != b[i - 1]) &&
                    (i == b.Length - 1 || b[i] != b[i + 1]))
                    return "NO";
            }
        }

        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine().Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string b = Console.ReadLine();

            string result = Result.happyLadybugs(b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
