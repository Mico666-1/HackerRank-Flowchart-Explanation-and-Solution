using System;
using System.IO;

class Result
{
    /*
     * Complete the 'appendAndDelete' function below.
     */
    public static string appendAndDelete(string s, string t, int k)
    {
        int commonLength = 0;

        // Find common prefix length
        while (commonLength < s.Length && commonLength < t.Length && s[commonLength] == t[commonLength])
            commonLength++;

        int totalOperations = (s.Length - commonLength) + (t.Length - commonLength);

        if (totalOperations > k)
            return "No";
        else if ((k - totalOperations) % 2 == 0 || k >= s.Length + t.Length)
            return "Yes";
        else
            return "No";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
