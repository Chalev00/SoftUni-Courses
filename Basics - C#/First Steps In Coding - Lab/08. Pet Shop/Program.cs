double dogFoodPrice = 2.50;
double catFoodPrice = 4;

int dogFoodAmount = int.Parse(Console.ReadLine());
int catFoodAmount = int.Parse(Console.ReadLine());

double finalPrice = (dogFoodAmount * dogFoodPrice) + (catFoodAmount * catFoodPrice);



Console.WriteLine($"{finalPrice} lv.");
