using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'isValid' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isValid(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Count frequency of each character
        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }

        // Count frequency of frequencies
        Dictionary<int, int> freqCount = new Dictionary<int, int>();
        foreach (int f in freq.Values)
        {
            if (!freqCount.ContainsKey(f))
                freqCount[f] = 0;
            freqCount[f]++;
        }

        // Case 1: All characters same frequency
        if (freqCount.Count == 1)
            return "YES";

        // Case 2: More than 2 frequency types -> invalid
        if (freqCount.Count > 2)
            return "NO";

        // Extract the two frequency types
        var keys = freqCount.Keys.ToList();
        int f1 = keys[0];
        int f2 = keys[1];

        // Check if one can be made valid by removing one character
        if ((freqCount[f1] == 1 && (f1 - 1 == 0 || f1 - 1 == f2)) ||
            (freqCount[f2] == 1 && (f2 - 1 == 0 || f2 - 1 == f1)))
            return "YES";

        return "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
