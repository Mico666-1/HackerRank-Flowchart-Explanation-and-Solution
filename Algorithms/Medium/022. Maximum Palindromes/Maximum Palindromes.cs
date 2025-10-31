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
    static long[] prefix;
    const int MOD = 1000000007;

    public static void initialize(string s)
    {
        int n = s.Length;
        prefix = new long[n + 1];
        for (int i = 1; i <= n; i++)
        {
            int val = s[i - 1] - 'a' + 1;
            prefix[i] = (prefix[i - 1] + val) % MOD;
        }
    }

    public static int answerQuery(int l, int r)
    {
        long result = (prefix[r] - prefix[l - 1] + MOD) % MOD;
        return (int)result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        Result.initialize(s);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int l = Convert.ToInt32(firstMultipleInput[0]);
            int r = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.answerQuery(l, r);
            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
