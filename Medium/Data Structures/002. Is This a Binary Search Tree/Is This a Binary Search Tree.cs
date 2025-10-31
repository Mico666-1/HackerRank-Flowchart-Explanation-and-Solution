using System;
using System.Collections.Generic;
using System.IO;

class Node
{
    public int data;
    public Node left, right;
    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

class Solution
{
    static bool checkBST(Node root)
    {
        return isBST(root, int.MinValue, int.MaxValue);
    }

    static bool isBST(Node node, int min, int max)
    {
        if (node == null)
            return true;

        if (node.data <= min || node.data >= max)
            return false;

        return isBST(node.left, min, node.data) && isBST(node.right, node.data, max);
    }

    // Example Main (optional for testing)
    static void Main(String[] args)
    {
        /* Example input for testing
           Construct tree:
                 4
               /   \
              2     6
             / \   / \
            1   3 5   7
        */
        Node root = new Node(4);
        root.left = new Node(2);
        root.right = new Node(6);
        root.left.left = new Node(1);
        root.left.right = new Node(3);
        root.right.left = new Node(5);
        root.right.right = new Node(7);

        Console.WriteLine(checkBST(root) ? "Yes" : "No");
    }
}
