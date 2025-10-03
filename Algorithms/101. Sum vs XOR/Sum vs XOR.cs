using System;
using System.IO;

class Result
{
    /*
     * Complete the 'sumXor' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long sumXor(long n)
    {
        if (n == 0) return 1; // Only 0 satisfies 0 ^ 0 = 0

        long count = 0;
        long temp = n;

        // Count number of 0 bits in binary representation of n
        while (temp > 0)
        {
            if ((temp & 1) == 0)
                count++;
            temp >>= 1;
        }

        // Each 0-bit can either be 0 or 1 in x, giving 2^count possibilities
        return 1L << (int)count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.sumXor(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
