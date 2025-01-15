int days = int.Parse(Console.ReadLine());
string accommodation = Console.ReadLine();
string rating = Console.ReadLine();

double accommodationPrice = 0;
if (accommodation == "room for one person")
{
    accommodationPrice = 18.00;
}
else if (accommodation == "apartment")
{
    accommodationPrice = 25.00;
    if (days < 10)
    {
        accommodationPrice = accommodationPrice * 0.70;
    }
    else if (days >= 10 && days <= 15)
    {
        accommodationPrice = accommodationPrice * 0.65;
    }
    else if (days > 15)
    {
        accommodationPrice = accommodationPrice * 0.50;
    }
}
else if (accommodation == "president apartment") 
{
    accommodationPrice = 35.00;
    if (days <10)
    {
        accommodationPrice = accommodationPrice * 0.90;
    }
    else if (days >= 10 && days <= 15)
    {
        accommodationPrice = accommodationPrice * 0.85;
    }
    else if (days > 15)
    {
        accommodationPrice = accommodationPrice * 0.80;
    }
}

if (rating == "positive") 
{
    accommodationPrice = accommodationPrice + (accommodationPrice * 0.25);
}
else
{
    accommodationPrice = accommodationPrice - (accommodationPrice * 0.1);
}

Console.WriteLine($"{accommodationPrice * (days - 1):F2}");