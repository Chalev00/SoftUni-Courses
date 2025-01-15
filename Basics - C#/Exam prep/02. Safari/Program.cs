double budget = double.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
double pricePerDay = double.Parse(Console.ReadLine());
int otherExpensesPercent = int.Parse(Console.ReadLine());

if (days > 7)
{
    pricePerDay = pricePerDay * 0.95;
}

double otherExpensesPrice = budget * ((double)otherExpensesPercent / 100);

double daysPrice = days * pricePerDay;
double fullPrice = daysPrice + otherExpensesPrice;

if (budget >= fullPrice)
{
    Console.WriteLine($"Ivanovi will be left with {budget - fullPrice:f2} leva after vacation.");
}
else
{
    Console.WriteLine($"{fullPrice - budget:f2} leva needed.");
}