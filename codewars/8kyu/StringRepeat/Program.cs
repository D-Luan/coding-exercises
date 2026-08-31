string s = "Hello";
int n = 5;

Console.WriteLine(RepeatStr(n, s));

static string RepeatStr(int n, string s)
{
    return string.Concat(Enumerable.Repeat(s, n));
}