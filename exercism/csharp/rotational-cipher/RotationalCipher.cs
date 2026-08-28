using System.Diagnostics.Tracing;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] letters = text.ToCharArray();    

        for (int i = 0; i < letters.Length; i++)
        {
            char currentChar = letters[i];

            if (char.IsLetter(currentChar))
            {
                char offset = char.IsUpper(currentChar) ? 'A' : 'a';
                letters[i] = (char)(((currentChar - offset + shiftKey) % 26) + offset);
            }
        }

        return new string(letters);
    }
}
