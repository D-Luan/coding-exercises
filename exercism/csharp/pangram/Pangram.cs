public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] characters = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        return input.ToLower().Any(c => input.Contains(c));
    }
}
