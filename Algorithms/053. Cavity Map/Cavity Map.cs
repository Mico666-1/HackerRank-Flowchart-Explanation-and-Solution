using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'cavityMap' function below.
     */
    public static List<string> cavityMap(List<string> grid)
    {
        int n = grid.Count;
        char[][] map = grid.Select(row => row.ToCharArray()).ToArray();

        for (int i = 1; i < n - 1; i++)
        {
            for (int j = 1; j < n - 1; j++)
            {
                char current = map[i][j];
                if (current > map[i-1][j] && current > map[i+1][j] &&
                    current > map[i][j-1] && current > map[i][j+1])
                {
                    map[i][j] = 'X';
                }
            }
        }

        List<string> result = map.Select(row => new string(row)).ToList();
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> grid = new List<string>();
        for (int i = 0; i < n; i++)
        {
            grid.Add(Console.ReadLine());
        }

        List<string> result = Result.cavityMap(grid);

        textWriter.WriteLine(String.Join("\n", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
