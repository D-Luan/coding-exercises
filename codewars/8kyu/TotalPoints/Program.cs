string[] games = 
{
    "1:0", "2:0", "3:0", "4:0", 
    "2:1", "3:1", "4:1", "3:2", 
    "4:2", "4:3"
};

int points = TotalPoints(games);
Console.WriteLine(points);

static int TotalPoints(string[] games)
{
    int points = 0;

    for (int i = 0; i < games.Length; i++)
    {
        string game = games[i];

        int x = game[0];
        int y = game[^1];

        points += x > y ? 3 : x == y ? 1 : 0;
    }

    return points;
}