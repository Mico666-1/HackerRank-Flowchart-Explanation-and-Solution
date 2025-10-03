using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'misereNim' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY s as parameter.
     */

    public static string misereNim(List<int> s)
    {
        int nimSum = 0;
        int countGreaterThanOne = 0;

        foreach (int pile in s)
        {
            nimSum ^= pile;
            if (pile > 1)
                countGreaterThanOne++;
        }

        // Special case: all piles have height 1
        if (countGreaterThanOne == 0)
        {
            if (s.Count % 2 == 0)
                return "First";
            else
                return "Second";
        }

        // General case
        return nimSum == 0 ? "Second" : "First";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string result = Result.misereNim(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
