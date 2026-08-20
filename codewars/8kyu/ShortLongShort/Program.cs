string a = "232";
string b = "1";

Console.WriteLine(ShortLongShort(a, b));

static string ShortLongShort(string a, string b)
{
    return (a.Length < b.Length) ? (a + b + a) : (b + a + b);
}