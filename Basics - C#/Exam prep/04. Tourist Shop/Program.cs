int days = int.Parse(Console.ReadLine());
double totalFood = double.Parse(Console.ReadLine());

double biscuit = 0;
double totalDogEatenFood = 0;
double totalCatEatenFood = 0;

for (int i = 1; i <= days; i++)
{
    int dogEatenFood = int.Parse(Console.ReadLine());
    int catEatenFood = int.Parse(Console.ReadLine());

    totalDogEatenFood += dogEatenFood;
    totalCatEatenFood += catEatenFood;

    if (i % 3 == 0)
    {
        biscuit += (dogEatenFood + catEatenFood) * 0.1;
    }
}

double totalEatenFood = totalCatEatenFood + totalDogEatenFood;
double percentTotalEatenFood = (totalEatenFood / totalFood) * 100;
double percentDogFoodEaten = totalDogEatenFood / totalEatenFood * 100;
double percentCatFoodEaten = totalCatEatenFood / totalEatenFood * 100;


Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuit)}gr.");
Console.WriteLine($"{percentTotalEatenFood:f2}% of the food has been eaten.");
Console.WriteLine($"{percentDogFoodEaten:f2}% eaten from the dog.");
Console.WriteLine($"{percentCatFoodEaten:f2}% eaten from the cat.");