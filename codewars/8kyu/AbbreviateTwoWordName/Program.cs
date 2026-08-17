string name = "patrick feeney";
Console.WriteLine(AbbrevName(name));

static string AbbrevName(string name)
{
    string[] names = name.Split(' ');

    char firstName = names[0][0];
    char surname = names[1][0];

    return $"{firstName}.{surname}".ToUpper();
}