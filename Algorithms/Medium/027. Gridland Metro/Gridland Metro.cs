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
    public static int gridlandMetro(int n, int m, int k, List<List<int>> track)
    {
        Dictionary<int, List<(int, int)>> rows = new Dictionary<int, List<(int, int)>>();

        // Store track ranges by row
        foreach (var t in track)
        {
            int r = t[0], c1 = t[1], c2 = t[2];
            if (!rows.ContainsKey(r))
                rows[r] = new List<(int, int)>();
            rows[r].Add((c1, c2));
        }

        long totalCells = (long)n * m;
        long occupied = 0;

        // Merge overlapping tracks
        foreach (var kvp in rows)
        {
            var segments = kvp.Value.OrderBy(x => x.Item1).ToList();
            int start = segments[0].Item1;
            int end = segments[0].Item2;

            foreach (var seg in segments.Skip(1))
            {
                if (seg.Item1 <= end)
                    end = Math.Max(end, seg.Item2);
                else
                {
                    occupied += (end - start + 1);
                    start = seg.Item1;
                    end = seg.Item2;
                }
            }
            occupied += (end - start + 1);
        }

        return (int)(totalCells - occupied);
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
        int k = Convert.ToInt32(firstMultipleInput[2]);

        List<List<int>> track = new List<List<int>>();

        for (int i = 0; i < k; i++)
        {
            track.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(trackTemp => Convert.ToInt32(trackTemp)).ToList());
        }

        int result = Result.gridlandMetro(n, m, k, track);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
