string str = "world";

Console.WriteLine(ReverseString(str));

static string ReverseString(string str)
{
    char[] array = str.ToCharArray();

    Array.Reverse(array);

    return new string(array);
}