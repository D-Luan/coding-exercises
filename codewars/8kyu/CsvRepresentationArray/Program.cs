using System.Text;

int[][] array = 
{
    new[] { 0, 1, 2, 3, 45 },
    new[] { 10, 11, 12, 13, 14 },
    new[] { 20, 21, 22, 23, 24 },
    new[] { 30, 31, 32, 33, 34 }
};

Console.WriteLine(ToCsvText(array));

static string ToCsvText(int[][] array)
{
    return string.Join("\n", array.Select(row => string.Join(",", row)));
}