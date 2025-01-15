double budget = double.Parse(Console.ReadLine());
int graphicsCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double graphicsCardPrice = graphicsCards * 250;

double processorPrice = processors * (graphicsCardPrice * 0.35);

double ramPrice = ram * (graphicsCardPrice * 0.1);

double fullPrice = graphicsCardPrice + processorPrice + ramPrice;

if (graphicsCards > processors)
{
    fullPrice = fullPrice * 0.85;
}

if (budget >= fullPrice)
{
    double moneyLeft = budget - fullPrice;
    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
}
else
{
    double neededMoney = fullPrice - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
}
