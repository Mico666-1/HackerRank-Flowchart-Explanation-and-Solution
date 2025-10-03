using System;
using System.Linq;

class Solution
{
    public static void insertionSort(int[] A)
    {
        for (int i = 1; i < A.Length; i++)
        {
            int value = A[i];
            int j = i - 1;

            while (j >= 0 && value < A[j])
            {
                A[j + 1] = A[j];
                j--;
            }

            A[j + 1] = value;
        }

        Console.WriteLine(string.Join(" ", A));
    }

    static void Main(string[] args)
    {
        Console.ReadLine(); // discard length
        int[] _ar = Console.ReadLine().Split().Select(int.Parse).ToArray();
        insertionSort(_ar);
    }
}
