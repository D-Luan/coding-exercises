public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word.Length is 0 or 1)
        {
            return true;
        }

        HashSet<char> characters = new(word[0]);

        for (int i = 1; i < word.Length; i++)
        {
            if (characters.Contains(word[i]))
            {
                return false;
            }

            characters.Add(word[i]);
        }

        return true;
    }
}
