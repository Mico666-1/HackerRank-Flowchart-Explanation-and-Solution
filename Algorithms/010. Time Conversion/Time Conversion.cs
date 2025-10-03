using System;
using System.IO;

class Result
{
    public static string timeConversion(string s)
    {
        // Extract hour, minutes, seconds and AM/PM part
        int hour = int.Parse(s.Substring(0, 2));
        string minutes = s.Substring(3, 2);
        string seconds = s.Substring(6, 2);
        string amPm = s.Substring(8, 2);

        if (amPm == "AM")
        {
            if (hour == 12)
                hour = 0; // midnight hour is 00 in 24-hour format
        }
        else // PM
        {
            if (hour != 12)
                hour += 12; // add 12 hours for PM except 12 PM itself
        }

        return $"{hour:D2}:{minutes}:{seconds}";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
