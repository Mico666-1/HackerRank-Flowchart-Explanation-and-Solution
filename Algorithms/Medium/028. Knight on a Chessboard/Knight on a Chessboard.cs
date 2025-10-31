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
    static int BFS(int n, int a, int b)
    {
        int[,] moves = new int[,] { { a, b }, { a, -b }, { -a, b }, { -a, -b }, { b, a }, { b, -a }, { -b, a }, { -b, -a } };
        bool[,] visited = new bool[n, n];
        Queue<(int, int, int)> q = new Queue<(int, int, int)>();
        q.Enqueue((0, 0, 0));
        visited[0, 0] = true;

        while (q.Count > 0)
        {
            var (x, y, steps) = q.Dequeue();
            if (x == n - 1 && y == n - 1) return steps;

            for (int i = 0; i < 8; i++)
            {
                int nx = x + moves[i, 0];
                int ny = y + moves[i, 1];
                if (nx >= 0 && ny >= 0 && nx < n && ny < n && !visited[nx, ny])
                {
                    visited[nx, ny] = true;
                    q.Enqueue((nx, ny, steps + 1));
                }
            }
        }
        return -1;
    }

    public static List<List<int>> knightlOnAChessboard(int n)
    {
        List<List<int>> result = new List<List<int>>();
        for (int a = 1; a < n; a++)
        {
            List<int> row = new List<int>();
            for (int b = 1; b < n; b++)
            {
                row.Add(BFS(n, a, b));
            }
            result.Add(row);
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<List<int>> result = Result.knightlOnAChessboard(n);
        textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
        textWriter.Flush();
        textWriter.Close();
    }
}
