public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastNumber = number % 10;
        int twoDigits = number % 100;

        string ordinalNumeral = string.Empty;

        ordinalNumeral = (lastNumber, twoDigits) switch
        {
            (1, not 11) => "st",
            (2, not 12) => "nd",
            (3, not 13) => "rd",
            _ => "th"
        };

        return $"{name}, you are the {number}{ordinalNumeral} customer we serve today. Thank you!";
    }
}
