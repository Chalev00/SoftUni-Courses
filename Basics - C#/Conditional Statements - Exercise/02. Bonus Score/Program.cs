int points = int.Parse(Console.ReadLine());

double bonusOne = 0;

if (points <= 100)
{
    bonusOne = 5;
}
else if (points < 1000)
{
    bonusOne = points * 0.2;
}
else 
{
    bonusOne = points * 0.1;
}

double bonusTwo = 0;

if (points % 2 == 0)
{
    bonusTwo = 1;
}
else if (points % 10 == 5)
{
    bonusTwo = 2;
}

Console.WriteLine(bonusOne + bonusTwo);
Console.WriteLine(points + bonusOne + bonusTwo);
