using System;
using System.IO;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        s = s.ToLower();
        HashSet<char> letters = new HashSet<char>();

        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                letters.Add(c);
            }
        }

        return letters.Count == 26 ? "pangram" : "not pangram";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
