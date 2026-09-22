string text = "HELLO I AM DONALD";

Console.WriteLine($"Text is Upper? {IsUpperCase(text)}");

static bool IsUpperCase(string text) => text == text.ToUpper();