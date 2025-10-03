using System;

class Result
{
    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + new string('#', i));
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
