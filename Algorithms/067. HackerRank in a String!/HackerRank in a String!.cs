using System;
using System.IO;

class Result
{
    /*
     * Complete the 'hackerrankInString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string hackerrankInString(string s)
    {
        string target = "hackerrank";
        int index = 0;

        foreach (char c in s)
        {
            if (c == target[index])
            {
                index++;
            }

            if (index
