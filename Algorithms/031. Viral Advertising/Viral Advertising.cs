using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */
    public static int viralAdvertising(int n)
    {
        int shared = 5;
        int cumulative = 0;

        for (int day = 1; day <= n; day++)
        {
            int liked = shared / 2;
            cumulative += liked;
            shared = liked * 3;
        }

        return cumulative;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
