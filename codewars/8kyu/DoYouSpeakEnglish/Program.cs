using System;

string sentence = "abcEnglishdef";
Console.WriteLine(SpeakEnglish(sentence));

sentence = "abcnEglishsef";
Console.WriteLine(SpeakEnglish(sentence));

static bool SpeakEnglish(string sentence)
{
    return sentence.Contains("english", StringComparison.OrdinalIgnoreCase);
}