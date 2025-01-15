double budget = double.Parse(Console.ReadLine());
int people =  int.Parse(Console.ReadLine());
double clothingPrice = double.Parse(Console.ReadLine());

double decorPrice = budget * 0.1;

double clothingPriceSum = people * clothingPrice;
if (people > 150)
{
    clothingPriceSum = clothingPriceSum * 0.9;
}

double finalBudget = decorPrice + clothingPriceSum;

if (finalBudget > budget)
{
    double neededMoney = finalBudget - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
}
else
{
    double moneyLeft = budget - finalBudget;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}