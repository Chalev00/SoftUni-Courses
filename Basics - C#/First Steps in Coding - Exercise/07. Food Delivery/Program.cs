double chicken = 10.35;
double fish = 12.40;
double veggie = 8.15;
double delivery = 2.50;

int chickenNum = int.Parse(Console.ReadLine());
int fishNum = int.Parse(Console.ReadLine());
int veggieNum = int.Parse(Console.ReadLine());

double allChicken = chicken * chickenNum;
double allFish = fish * fishNum;
double allVeggie = veggie * veggieNum;

double fullPrice = allChicken + allFish + allVeggie;

double dessert = fullPrice * 0.20;

double finalPrice = fullPrice + dessert + delivery;

Console.WriteLine(finalPrice);