int groupBudget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double shipRent = 0;

if (season == "Spring") 
{
    shipRent = 3000;    
}
else if (season == "Summer" || season == "Autumn")
{
    shipRent = 4200;
}
else if (season == "Winter")
{
    shipRent = 2600;
}

if (fishermen <= 6)
{
    shipRent = shipRent - (shipRent * 0.10);   
}
else if (fishermen <= 11)
{
    shipRent = shipRent - (shipRent * 0.15);
}
else if (fishermen >= 12)
{
    shipRent = shipRent - (shipRent * 0.25);
}

if (fishermen % 2 == 0 && season != "Autumn")
{
    shipRent = shipRent - (shipRent * 0.05);
}

if (groupBudget >= shipRent)
{
    double moneyLeft = groupBudget - shipRent;
    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
}
else if (shipRent > groupBudget)
{
    double moneyNeeded = shipRent - groupBudget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
}