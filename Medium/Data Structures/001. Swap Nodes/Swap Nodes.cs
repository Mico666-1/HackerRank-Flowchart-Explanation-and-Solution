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
     * Complete the 'swapNodes' function below.
     *
     * The function is expected to return a 2D_INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. 2D_INTEGER_ARRAY indexes
     *  2. INTEGER_ARRAY queries
     */

    public static List<List<int>> swapNodes(List<List<int>> indexes, List<int> queries)
    {
        Node root = new Node(1);
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        for (int i = 0; i < indexes.Count; i++)
        {
            Node current = queue.Dequeue();
            int left = indexes[i][0];
            int right = indexes[i][1];

            if (left != -1)
            {
                current.left = new Node(left);
                queue.Enqueue(current.left);
            }

            if (right != -1)
            {
                current.right = new Node(right);
                queue.Enqueue(current.right);
            }
        }

        List<List<int>> result = new List<List<int>>();

        foreach (int k in queries)
        {
            SwapAtDepth(root, 1, k);
            List<int> inorderResult = new List<int>();
            InorderTraversal(root, inorderResult);
            result.Add(inorderResult);
        }

        return result;
    }
    
    private static void SwapAtDepth(Node node, int depth, int k)
    {
        if (node == null) return;

        if (depth % k == 0)
        {
            Node temp = node.left;
            node.left = node.right;
            node.right = temp;
        }

        SwapAtDepth(node.left, depth + 1, k);
        SwapAtDepth(node.right, depth + 1, k);
    }

    private static void InorderTraversal(Node node, List<int> result)
    {
        if (node == null) return;

        InorderTraversal(node.left, result);
        result.Add(node.data);
        InorderTraversal(node.right, result);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> indexes = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            indexes.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(indexesTemp => Convert.ToInt32(indexesTemp)).ToList());
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> queries = new List<int>();

        for (int i = 0; i < queriesCount; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<List<int>> result = Result.swapNodes(indexes, queries);

        textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

        textWriter.Flush();
        textWriter.Close();
    }
}
