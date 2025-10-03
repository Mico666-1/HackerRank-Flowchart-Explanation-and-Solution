public static string caesarCipher(string s, int k)
{
    StringBuilder result = new StringBuilder();
    k = k % 26; // Normalize shift

    foreach (char c in s)
    {
        if (char.IsUpper(c))
        {
            char shifted = (char)((c - 'A' + k) % 26 + 'A');
            result.Append(shifted);
        }
        else if (char.IsLower(c))
        {
            char shifted = (char)((c - 'a' + k) % 26 + 'a');
            result.Append(shifted);
        }
        else
        {
            result.Append(c);
        }
    }

    return result.ToString();
}
