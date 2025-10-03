using System;
using System.IO;

class Result
{
    /*
     * Complete the 'beautifulBinaryString' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING b as parameter.
     */

    public static int beautifulBinaryString(string b)
    {
        int changes = 0;
        int i = 0;
        string pattern = "010";

        while (i <= b.Length - 3)
        {
            if (b.Substring(i, 3) == pattern)
            {
                changes++;
                i += 3; // Skip past the changed segment
            }
            else
            {
                i++;
            }
        }

        return changes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string b = Console.ReadLine();

        int result = Result.beautifulBinaryString(b);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
