string[] x = { "bad", "bad", "bad" };
Console.WriteLine(Well(x));

static string Well(string[] x)
{
    int goodQty = x.Count(w => w == "good");

    return goodQty switch
    {
        > 2 => "I smell a series!",
        > 0 => "Publish!",
        _ => "Fail!"
    };
}