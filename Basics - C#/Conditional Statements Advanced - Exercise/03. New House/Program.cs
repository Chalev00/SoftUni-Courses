string flower = Console.ReadLine();
int flowerQuantity = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double flowerPrice = 0;
double finalPrice = 0;

if (flower == "Roses")
{
    flowerPrice = 5.00;
    if (flowerQuantity > 80)
    {
        finalPrice = (flowerPrice * flowerQuantity) * 0.9;
    }
    else
    {
        finalPrice = flowerPrice * flowerQuantity;
    }
}
else if (flower == "Dahlias")
{
    flowerPrice = 3.80;
    if (flowerQuantity > 90)
    {
        finalPrice = (flowerPrice * flowerQuantity) * 0.85;
    }
    else
    {
        finalPrice = flowerPrice * flowerQuantity;
    }
}
else if (flower == "Tulips")
{
    flowerPrice = 2.80;
    if (flowerQuantity > 80)
    {
        finalPrice = (flowerPrice * flowerQuantity) * 0.85;
    }
    else
    {
        finalPrice = flowerPrice * flowerQuantity;
    }
}
else if (flower == "Narcissus")
{
    flowerPrice = 3;
    if (flowerQuantity < 120)
    {
        finalPrice = (flowerPrice * flowerQuantity) + ((flowerPrice * flowerQuantity) * 0.15);
    }
    else
    {
        finalPrice = flowerPrice * flowerQuantity;
    }
}
else if (flower == "Gladiolus")
{
    flowerPrice = 2.50;
    if (flowerQuantity < 80)
    {
        finalPrice = (flowerPrice * flowerQuantity) + ((flowerPrice * flowerQuantity) * 0.2);
    }
    else
    {
        finalPrice = flowerPrice * flowerQuantity;
    }
}

if (budget >= finalPrice)
{
    double budgetLeft = budget - finalPrice;
    Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {budgetLeft:F2} leva left.");
}
else if (finalPrice > budget)
{
    double budgetNeeded = finalPrice - budget;
    Console.WriteLine($"Not enough money, you need {budgetNeeded:F2} leva more.");
}
