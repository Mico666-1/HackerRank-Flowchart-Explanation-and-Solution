using System;

class Solution
{
    static string strings_xor(string s1, string s2)
    {
        string result = "";
        for (int i = 0; i < s1.Length; i++)
        {
            // XOR logic: if chars are equal, 0; else 1
            result += (s1[i] == s2[i]) ? '0' : '1';
        }
        return result;
    }

    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        Console.WriteLine(strings_xor(a, b));
    }
}
