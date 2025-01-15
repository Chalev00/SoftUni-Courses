double vacMoney = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int daysSpending = 0;
bool spent5ConsDays = false;
int daysPassed = 0;

while (availableMoney < vacMoney)
{
    string saveOrSpend = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    daysPassed++;

    if (saveOrSpend == "save")
    {
        availableMoney += money;
        daysSpending = 0;
    }
    else if (saveOrSpend == "spend")
    {
        availableMoney -= money;
        daysSpending++;

        if (availableMoney < 0)
        {
            availableMoney = 0;
        }
    }

    if (daysSpending >= 5)
    {
        spent5ConsDays = true;
        break;
    }
}

if (spent5ConsDays)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysPassed);
}
else
{
    Console.WriteLine($"You saved the money for {daysPassed} days.");
}