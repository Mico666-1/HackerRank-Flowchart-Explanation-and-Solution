using System;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'kaprekarNumbers' function below.
     */
    public static void kaprekarNumbers(int p, int q)
    {
        bool found = false;

        for (int n = p; n <= q; n++)
        {
            long sq = (long)n * n;
            string str = sq.ToString();
            string left = str.Length > 1 ? str.Substring(0, str.Length / 2) : "0";
            string right = str.Substring(str.Length / 2);

            int l = int.Parse(left);
            int r = int.Parse(right);

            if (l + r == n)
            {
                Console.Write(n + " ");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("INVALID RANGE");
        else
            Console.WriteLine();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
