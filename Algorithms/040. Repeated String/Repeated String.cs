using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'repeatedString' function below.
     */
    public static long repeatedString(string s, long n)
    {
        long countA = s.Count(c => c == 'a');          // Count 'a' in the original string
        long fullRepeats = n / s.Length;               // Number of full repetitions
        long remainder = n % s.Length;                // Remaining characters

        long totalA = fullRepeats * countA;           // 'a's from full repetitions
        totalA += s.Substring(0, (int)remainder).Count(c => c == 'a'); // 'a's from remainder

        return totalA;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
