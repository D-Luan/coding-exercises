string s = "Hi!!!";
Console.WriteLine(RemoveExclamation(s));

static string RemoveExclamation(string s)
{
    if (s.EndsWith("!"))
    {
        return s.Substring(0, s.Length - 1);
    }

    return s;
}