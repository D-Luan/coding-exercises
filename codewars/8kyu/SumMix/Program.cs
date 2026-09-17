object[] x = { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" };

Console.WriteLine(SumMix(x));

static int SumMix(object[] x) => x.Sum(Convert.ToInt32);