using System;

string url = "https://gemini.google.com";
bool result = LinkValidator(url);

Console.WriteLine((result is true) ? "It's safe" : "Danger!!!");

static bool LinkValidator(string url)
{
    bool start = url.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
    bool end = url.EndsWith(".com", StringComparison.OrdinalIgnoreCase);

    return start && end;
}