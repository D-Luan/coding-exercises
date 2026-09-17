string str = "The greatest victory is that which requires no battle";

Console.WriteLine(ReverseWords(str));

static string ReverseWords(string str)
{
    return string.Join(" ", str.Split(' ').Reverse());
}