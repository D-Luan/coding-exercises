string s = "eloquent";

Console.WriteLine(RemoveChar(s));

static string RemoveChar(string s) => s[1..^1];