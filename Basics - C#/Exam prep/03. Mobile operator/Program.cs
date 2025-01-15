double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double dayPrice = 0;

if (season == "Winter")
{
    if (destination == "Dubai")
    {
        dayPrice = 45000 * 0.7;
    }
    else if (destination == "Sofia")
    {
        dayPrice = 17000 * 1.25 ;
    }
    else if (destination == "London")
    {
        dayPrice = 24000;
    }
}
else if (season == "Summer")
{
    if (destination == "Dubai")
    {
        dayPrice = 40000 * 0.7;
    }
    else if (destination == "Sofia")
    {
        dayPrice = 12500 * 1.25;
    }
    else if (destination == "London")
    {
        dayPrice = 20250;
    }
}

double fullPrice = dayPrice * days;

if (budget >= fullPrice)
{
    Console.WriteLine($"The budget for the movie is enough! We have {budget - fullPrice:f2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {fullPrice - budget:f2} leva more!");
}