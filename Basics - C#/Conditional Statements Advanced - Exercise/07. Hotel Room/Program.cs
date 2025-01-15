string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    apPrice = 65;

    if (nights > 14)
    {
        studioPrice = studioPrice * 0.70;
        apPrice = apPrice * 0.90;
    }
    else if (nights > 7)
    {
        studioPrice = studioPrice * 0.95;
    }

}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apPrice = 68.70;

    if (nights > 14)
    {
        studioPrice = studioPrice * 0.80;
        apPrice = apPrice * 0.9;
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    apPrice = 77;

    if (nights > 14) 
    {
        apPrice = apPrice * 0.9;   
    }
}

Console.WriteLine($"Apartment: {apPrice * nights:F2} lv.");
Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");