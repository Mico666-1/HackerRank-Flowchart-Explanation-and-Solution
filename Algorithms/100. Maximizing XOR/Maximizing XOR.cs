using System;
using System.IO;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'maximizingXor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER l
     *  2. INTEGER r
     */

    public static int maximizingXor(int l, int r)
    {
        int maxXor = 0;

        for (int i = l; i <= r; i++)
        {
            for (int j = i; j <= r; j++)
            {
                int currentXor = i ^ j;
                if (currentXor > maxXor)
                    maxXor = currentXor;
            }
        }

        return maxXor;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());
        int r = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.maximizingXor(l, r);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
