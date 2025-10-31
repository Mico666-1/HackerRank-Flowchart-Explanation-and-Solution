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
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        char[] arr = w.ToCharArray();
        int i = arr.Length - 2;

        // Step 1: Find first decreasing element from the end
        while (i >= 0 && arr[i] >= arr[i + 1])
            i--;

        // If no such element, it's already the largest permutation
        if (i < 0)
            return "no answer";

        // Step 2: Find element just larger than arr[i] to the right
        int j = arr.Length - 1;
        while (arr[j] <= arr[i])
            j--;

        // Step 3: Swap them
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;

        // Step 4: Reverse the suffix
        Array.Reverse(arr, i + 1, arr.Length - i - 1);

        return new string(arr);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
