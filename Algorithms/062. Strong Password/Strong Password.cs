using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    /*
     * Complete the 'minimumNumber' function below.
     *
     * Returns the minimum number of characters to make the password strong.
     */
    public static int minimumNumber(int n, string password)
    {
        bool hasDigit = false;
        bool hasLower = false;
        bool hasUpper = false;
        bool hasSpecial = false;

        string specialChars = "!@#$%^&*()-+";

        foreach (char ch in password)
        {
            if (char.IsDigit(ch)) hasDigit = true;
            else if (char.IsLower(ch)) hasLower = true;
            else if (char.IsUpper(ch)) hasUpper = true;
            else if (specialChars.Contains(ch)) hasSpecial = true;
        }

        int missingTypes = 0;
        if (!hasDigit) missingTypes++;
        if (!hasLower) missingTypes++;
        if (!hasUpper) missingTypes++;
        if (!hasSpecial) missingTypes++;

        int minLengthRequirement = Math.Max(0, 6 - n);

        return Math.Max(missingTypes, minLengthRequirement);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);
        textWriter.Flush();
        textWriter.Close();
    }
}
