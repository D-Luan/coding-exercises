int num = 123;
Console.WriteLine(NumberToString(num));

num = 999;
Console.WriteLine(NumberToString(num));

num = -100;
Console.WriteLine(NumberToString(num));

static string NumberToString(int num)
{
    return num.ToString();
}