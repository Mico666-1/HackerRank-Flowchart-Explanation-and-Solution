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
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        // Remove spaces from the string
        s = s.Replace(" ", "");

        int length = s.Length;
        double sqrtLen = Math.Sqrt(length);
        int rows = (int)Math.Floor(sqrtLen);
        int cols = (int)Math.Ceiling(sqrtLen);

        if (rows * cols < length)
            rows++;

        StringBuilder result = new StringBuilder();

        // Build encrypted text by reading column-wise
        for (int i = 0; i < cols; i++)
        {
            for (int j = i; j < length; j += cols)
            {
                result.Append(s[j]);
            }
            if (i < cols - 1)
                result.Append(' ');
        }

        return result.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
