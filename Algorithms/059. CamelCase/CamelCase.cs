using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'camelcase' function below.
     */
    public static int camelcase(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int words = 1; // First word always starts lowercase
        foreach (char c in s)
        {
            if (char.IsUpper(c))
                words++;
        }
        return words;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.camelcase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
