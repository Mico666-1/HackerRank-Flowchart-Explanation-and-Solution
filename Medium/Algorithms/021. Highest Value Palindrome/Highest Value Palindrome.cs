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
     * Complete the 'highestValuePalindrome' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER n
     *  3. INTEGER k
     */

    public static string highestValuePalindrome(string s, int n, int k)
    {
        char[] chars = s.ToCharArray();
        bool[] changed = new bool[n];
        int left = 0, right = n - 1;

        // First pass: make it a palindrome
        while (left < right)
        {
            if (chars[left] != chars[right])
            {
                char maxChar = (char)Math.Max(chars[left], chars[right]);
                chars[left] = chars[right] = maxChar;
                changed[left] = changed[right] = true;
                k--;
            }
            left++;
            right--;
        }

        if (k < 0)
            return "-1";

        // Second pass: maximize value (make as many 9s as possible)
        left = 0;
        right = n - 1;

        while (left <= right && k > 0)
        {
            if (left == right)
            {
                if (k > 0 && chars[left] != '9')
                    chars[left] = '9';
            }
            else
            {
                if (chars[left] != '9')
                {
                    if (changed[left] || changed[right])
                    {
                        if (k >= 1)
                        {
                            chars[left] = chars[right] = '9';
                            k -= 1;
                        }
                    }
                    else if (k >= 2)
                    {
                        chars[left] = chars[right] = '9';
                        k -= 2;
                    }
                }
            }
            left++;
            right--;
        }

        return new string(chars);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        string s = Console.ReadLine();

        string result = Result.highestValuePalindrome(s, n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
