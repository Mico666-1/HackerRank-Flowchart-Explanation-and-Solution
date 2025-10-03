using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'acmTeam' function below.
     */
    public static List<int> acmTeam(List<string> topic)
    {
        int n = topic.Count;
        int m = topic[0].Length;
        int maxTopics = 0;
        int teamCount = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int topicsKnown = 0;
                for (int k = 0; k < m; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                        topicsKnown++;
                }

                if (topicsKnown > maxTopics)
                {
                    maxTopics = topicsKnown;
                    teamCount = 1;
                }
                else if (topicsKnown == maxTopics)
                {
                    teamCount++;
                }
            }
        }

        return new List<int> { maxTopics, teamCount };
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

        List<string> topic = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string topicItem = Console.ReadLine();
            topic.Add(topicItem);
        }

        List<int> result = Result.acmTeam(topic);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
