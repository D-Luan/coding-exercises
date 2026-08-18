public static class LineUp
{
    public static string Format(string name, int number)
    {
        char[] numbers = number.ToString().ToCharArray();
        int lastNumber = numbers[^1] - '0';

        string ordinalNumeral = lastNumber switch
        {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th"
        };

        return $"{name}, you are the {number}{ordinalNumeral} customer we serve today. Thank you!";
    }
}
