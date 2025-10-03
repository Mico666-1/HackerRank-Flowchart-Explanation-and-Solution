using System;
using System.IO;

class Result
{
    /*
     * Complete the 'gameOfThrones' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string gameOfThrones(string s)
    {
        int[] freq = new int[26];

        foreach (char c in s)
            freq[c - 'a']++;

        int oddCount = 0;
        foreach (int count in freq)
        {
            if (count % 2 != 0)
                oddCount++;
        }

        // Palindrome possible if at most one character has odd frequency
        return oddCount <= 1 ? "YES" : "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
