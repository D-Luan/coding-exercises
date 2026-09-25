int salary = 10000;
bool bonus = true;

Console.WriteLine(BonusTime(salary, bonus));

static string BonusTime(int salary, bool bonus)
{
    return bonus is true ? ("$" + salary * 10) : ("$" + salary);
}