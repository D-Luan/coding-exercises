string x = "45323897729310";
Console.WriteLine(FakeBin(x));

static string FakeBin(string x)
{
    char[] array = x.ToCharArray();
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < '5')
        {
            array[i] = '0';
        }
        else
        {
            array[i] = '1';
        }
    }

    return new String(array);
}