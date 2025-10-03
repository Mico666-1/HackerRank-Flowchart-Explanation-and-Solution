using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
        int maxHeight = 0;
        foreach (char c in word)
        {
            int index = c - 'a'; // position of the character in alphabet
            maxHeight = Math.Max(maxHeight, h[index]);
        }
        return maxHeight * word.Length;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
