string str = "I love arrays they are my favorite";
string[] array = StringToArray(str);

foreach(string s in array)
{
    Console.WriteLine(s);
}

static string[] StringToArray(string str) => str.Split(" ");