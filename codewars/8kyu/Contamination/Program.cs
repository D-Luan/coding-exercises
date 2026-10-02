string text = "abc";

Console.WriteLine(Contamination(text, "z"));

static string Contamination(string text, string character)
{
    return string.Concat(Enumerable.Repeat(character, text.Length));
}