string str = "arara";
Console.WriteLine(IsPalindrome(str));

str = "casa";
Console.WriteLine(IsPalindrome(str));

static bool IsPalindrome(string str)
{
    string strLower = str.ToLower();

    string newStr = new String(strLower.Reverse().ToArray());

    return newStr == str;
}