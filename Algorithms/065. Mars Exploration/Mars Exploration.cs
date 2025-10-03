using System;
using System.IO;

class Result
{
    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        int alteredCount = 0;
        string expectedMessage = "SOS";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != expectedMessage[i % 3])
            {
                alteredCount++;
            }
        }

        return alteredCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
