double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string campOrHotel = "";

if (budget <= 100)
{
    destination = "Bulgaria";
}
else if (budget <= 1000)
{
    destination = "Balkans";
}
else
{
    destination = "Europe";
}

if (destination == "Bulgaria") 
{
    if (season == "summer")
    {
        campOrHotel = "Camp";
        budget = budget - (budget * 0.7);
    }
    else if (season == "winter")
    {
        campOrHotel = "Hotel";
        budget = budget - (budget * 0.3);
    }
}
else if (destination == "Balkans")
{
    if (season == "summer")
    {
        campOrHotel = "Camp";
        budget = budget - (budget * 0.60);
    }
    else if (season == "winter")
    {
        campOrHotel = "Hotel";
        budget = budget - (budget * 0.20);
    }
}
else if (destination == "Europe")
{
    campOrHotel = "Hotel";
    budget = budget - (budget * 0.10);
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{campOrHotel} - {budget:F2}");