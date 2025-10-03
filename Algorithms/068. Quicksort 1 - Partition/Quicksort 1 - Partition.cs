using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'quickSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> quickSort(List<int> arr)
    {
        if (arr.Count <= 1)
            return arr;

        int pivot = arr[0];
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] <= pivot)
