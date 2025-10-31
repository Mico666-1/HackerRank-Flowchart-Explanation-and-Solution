using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'twoPluses' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static int twoPluses(List<string> grid)
    {
        int n = grid.Count;
        int m = grid[0].Length;
        List<(int r, int c, int size)> pluses = new List<(int, int, int)>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 'G')
                {
                    int size = 0;
                    while (IsValid(grid, i, j, size))
                    {
                        pluses.Add((i, j, size));
                        size++;
                    }
                }
            }
        }

        int maxProduct = 0;
        for (int a = 0; a < pluses.Count; a++)
        {
            var p1 = GetCells(pluses[a]);
            for (int b = a + 1; b < pluses.Count; b++)
            {
                var p2 = GetCells(pluses[b]);
                if (!p1.Intersect(p2).Any())
                {
                    int product = p1.Count * p2.Count;
                    maxProduct = Math.Max(maxProduct, product);
                }
            }
        }

        return maxProduct;
    }

    private static bool IsValid(List<string> grid, int r, int c, int size)
    {
        int n = grid.Count;
        int m = grid[0].Length;
        if (r - size < 0 || r + size >= n || c - size < 0 || c + size >= m)
            return false;
        return grid[r - size][c] == 'G' && grid[r + size][c] == 'G' &&
               grid[r][c - size] == 'G' && grid[r][c + size] == 'G';
    }

    private static HashSet<(int, int)> GetCells((int r, int c, int size) plus)
    {
        HashSet<(int, int)> cells = new HashSet<(int, int)>();
        cells.Add((plus.r, plus.c));
        for (int k = 1; k <= plus.size; k++)
        {
            cells.Add((plus.r + k, plus.c));
            cells.Add((plus.r - k, plus.c));
            cells.Add((plus.r, plus.c + k));
            cells.Add((plus.r, plus.c - k));
        }
        return cells;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<string> grid = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        int result = Result.twoPluses(grid);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
