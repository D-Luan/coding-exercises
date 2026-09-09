string input = "8aaaaa dddd r     ";

Console.WriteLine(NoSpace(input));

static string NoSpace(string input) => input.Replace(" ", "");