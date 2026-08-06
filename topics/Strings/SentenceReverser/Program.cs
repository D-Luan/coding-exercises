string sentence = "Eu gosto de programar";
sentence = ReverseWords(sentence);

Console.WriteLine(sentence);

static string ReverseWords(string sentence)
{
    return string.Join(" ", sentence.Split(' ').Reverse());
}