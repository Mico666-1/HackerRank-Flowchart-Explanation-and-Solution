using System;
using System.Numerics;

class Result
{
    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        bool found = false;

        for (int len = 1; len <= s.Length / 2; len++)
        {
            string firstNumStr = s.Substring(0, len);
            BigInteger firstNum = BigInteger.Parse(firstNumStr);
            BigInteger nextNum = firstNum;

            int index = 0;

            while (index < s.Length)
            {
                string nextStr = nextNum.ToString();
                if (s.Substring(index, nextStr.Length) != nextStr)
                {
                    break;
                }
                index += nextStr.Length;
                nextNum += 1;
            }

            if (index == s.Length)
            {
                Console.WriteLine("YES " + firstNum);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("NO");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}
