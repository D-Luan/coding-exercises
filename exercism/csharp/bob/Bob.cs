public static class Bob
{
    public static string Response(string statement)
    {
        return statement.Trim() switch
        {
            string s when string.IsNullOrWhiteSpace(s) => "Fine. Be that way!",
            string s when s.Any(char.IsLetter) && s == s.ToUpper() && s.EndsWith("?") => "Calm down, I know what i'm doing!",
            string s when s.Any(char.IsLetter) && s == s.ToUpper() => "Whoa, chill out!",
            string s when s.EndsWith("?") => "Sure.",
            _ => "Whatever."
        };
    }
}
