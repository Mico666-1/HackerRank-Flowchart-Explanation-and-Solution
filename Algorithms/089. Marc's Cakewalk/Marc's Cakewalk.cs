using System;
using System.IO;
using System.Collections.Generic;

class Result
{
    /*
     * Complete the 'marcsCakewalk' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY calorie as parameter.
     */

    public static long marcsCakewalk(List<int> calorie)
    {
        calorie.Sort((a, b) => b.CompareTo(a)); // Sort in descending order
        long miles = 0;

        for (int i = 0; i < calorie.Count; i++)
        {
            miles += (long)Math.Pow(2, i) * calorie[i];
        }

        return miles;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> calorie = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(calorieTemp => Convert.ToInt32(calorieTemp)).ToList();

        long result = Result.marcsCakewalk(calorie);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
