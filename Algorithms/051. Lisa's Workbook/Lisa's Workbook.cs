using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'workbook' function below.
     */
    public static int workbook(int n, int k, List<int> arr)
    {
        int specialProblems = 0;
        int pageNumber = 1;

        for (int i = 0; i < n; i++)
        {
            int problems = arr[i];
            for (int j = 1; j <= problems; j++)
            {
                if (j == pageNumber)
                {
                    specialProblems++;
                }
                if (j % k == 0 || j == problems)
                {
                    pageNumber++;
                }
            }
        }

        return specialProblems;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
