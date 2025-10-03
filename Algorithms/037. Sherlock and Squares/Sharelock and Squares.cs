using System;
using System.IO;

class Result
{
    /*
     * Complete the 'squares' function below.
     */
    public static int squares(int a, int b)
    {
        int start = (int)Math.Ceiling(Math.Sqrt(a));
        int end = (int)Math.Floor(Math.Sqrt(b));
        return Math.Max(0, end - start + 1);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(firstMultipleInput[0]);
            int b = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.squares(a, b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
