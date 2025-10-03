using System;
using System.IO;

class Result
{
    /*
     * Complete the 'funnyString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string funnyString(string s)
    {
        int n = s.Length;

        for (int i = 1; i < n; i++)
        {
            int diffOriginal = Math.Abs(s[i] - s[i - 1]);
            int diffReversed = Math.Abs(s[n - i] - s[n - i - 1]);

            if (diffOriginal != diffReversed)
                return "Not Funny";
        }

        return "Funny";
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

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
