int number = 5;

Console.WriteLine(MultiTable(number));

static string MultiTable(int number)
{
    string result = "";

    for (int i = 1; i <= 10; i++)
    {
        result = result + $"{i} * {number} = {i * number}";

        if (i != 10) result += "\n";
    }

    return result;
}