int n = 3;

Console.WriteLine(CountSheep(n));

static string CountSheep(int n)
{
    return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
}