using System;
using System.IO;

class Result
{
    /*
     * Complete the 'gameOfStones' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string gameOfStones(int n)
    {
        // If n % 4 == 0, the player to move loses (second player wins)
        if (n % 4 == 0)
            return "Second";
        else
            return "First";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.gameOfStones(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
