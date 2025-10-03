using System;
using System.IO;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
        int n = s.Length;
        // If string length is odd, impossible to split into two anagrams
        if (n % 2 != 0)
            return -1;

        string first = s.Substring(0, n / 2);
        string second = s.Substring(n / 2, n / 2);

        int[] freq = new int[26];

        foreach (char c in first)
            freq[c - 'a']++;

        foreach (char c in second)
            freq[c - 'a']--;

        int changes = 0;
        foreach (int count in freq)
        {
            if (count > 0)
                changes += count;
        }

        return changes;
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

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
