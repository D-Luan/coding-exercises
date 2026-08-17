string name = "Robert Smith";
Console.WriteLine(Greet(name));

static string Greet(string name)
{
    return $"Hello, {name} how are you doing today?";
}