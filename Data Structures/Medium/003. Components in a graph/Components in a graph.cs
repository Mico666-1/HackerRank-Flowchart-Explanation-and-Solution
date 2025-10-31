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
     * Complete the 'componentsInGraph' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY gb as parameter.
     */

    public static List<int> componentsInGraph(List<List<int>> gb)
    {
        int n = gb.Count;
        int maxNodes = 2 * n + 1;
        List<int>[] graph = new List<int>[maxNodes];

        for (int i = 0; i < maxNodes; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var edge in gb)
        {
            int u = edge[0];
            int v = edge[1];
            graph[u].Add(v);
            graph[v].Add(u);
        }

        bool[] visited = new bool[maxNodes];
        int minSize = int.MaxValue;
        int maxSize = int.MinValue;

        for (int i = 1; i < maxNodes; i++)
        {
            if (!visited[i] && graph[i].Count > 0)
            {
                int size = BFS(graph, i, visited);
                if (size > 1)
                {
                    minSize = Math.Min(minSize, size);
                    maxSize = Math.Max(maxSize, size);
                }
            }
        }

        return new List<int> { minSize, maxSize };
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> gb = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            gb.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(gbTemp => Convert.ToInt32(gbTemp)).ToList());
        }

        List<int> result = Result.componentsInGraph(gb);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
