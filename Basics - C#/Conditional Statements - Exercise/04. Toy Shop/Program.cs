double trip = double.Parse(Console.ReadLine());
int puzzleNum = int.Parse(Console.ReadLine());
int dollNum = int.Parse(Console.ReadLine());
int teddyNum = int.Parse(Console.ReadLine());
int minionNum = int.Parse(Console.ReadLine());
int truckNum = int.Parse(Console.ReadLine());

double puzzle = 2.60;
double doll = 3.00;
double teddy = 4.10;
double minion = 8.20;
double truck = 2.00;

double toysBill = (puzzle * puzzleNum) + (doll * dollNum) + (teddy * teddyNum) + 
    (minion * minionNum) + (truck * truckNum);

int WholeNum = puzzleNum + dollNum + teddyNum + minionNum + truckNum;

if (WholeNum >= 50)
{
    toysBill = toysBill * 0.75;
}

double rent = toysBill * 0.1;
toysBill = toysBill - rent;

if (toysBill >= trip)
{
    double moneyLeft = toysBill - trip;
    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
}
else
{
    double moneyNeeded = trip - toysBill;
    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
}