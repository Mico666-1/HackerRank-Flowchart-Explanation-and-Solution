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
     * Complete the 'substrings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING n as parameter.
     */

    public static int substrings(string n)
    {
        long mod = 1000000007;
        long total = 0;
        long multiplier = 1;
        long currentSum = 0;

        for (int i = n.Length - 1; i >= 0; i--)
        {
            int digit = n[i] - '0';
            currentSum = (currentSum + digit * multiplier * (i + 1)) % mod;
            multiplier = (multiplier * 10 + 1) % mod;
        }

        total = currentSum % mod;
        return (int)total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string n = Console.ReadLine();

        int result = Result.substrings(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
