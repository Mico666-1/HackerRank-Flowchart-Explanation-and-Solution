using System;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'decentNumber' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void decentNumber(int n)
    {
        int fives = n;

        while (fives % 3 != 0)
        {
            fives -= 5;
        }

        if (fives < 0)
        {
            Console.WriteLine("-1");
            return;
        }

        // Print fives
        for (int i = 0; i < fives; i++)
            Console.Write("5");

        // Print zeros
        for (int i = fives; i < n; i++)
            Console.Write("0");

        Console.WriteLine();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.decentNumber(n);
        }
    }
}
