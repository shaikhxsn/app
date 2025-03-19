public class StringUtils
{
    public static string GetMessage(string Message)
    {
        return Message;
    }

    public static bool AreAnagramsSorting(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false; // Different lengths → Not anagrams

        return string.Concat(s1.OrderBy(c => c)) == string.Concat(s2.OrderBy(c => c));
    }

    public static bool AreAnagramsFrequency(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false; // Different lengths → Not anagrams

        int[] chars = new int[256];

        foreach (var s in s1)
        {
            chars[s]++;
        }

        foreach (var s in s2)
        {
            chars[s]--;

            if (chars[s] < 0)
                return false;
        }

        return true;
    }
}