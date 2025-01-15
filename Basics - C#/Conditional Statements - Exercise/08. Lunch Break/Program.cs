string seriesName = Console.ReadLine();
int epLength = int.Parse(Console.ReadLine());
int brake = int.Parse(Console.ReadLine());

double lunchTime = brake * 0.125;
double restTime = brake * 0.25;

double brakeTimeLeft = brake - (lunchTime + restTime); 

if (brakeTimeLeft >= epLength)
{
    double timeLeft = brakeTimeLeft - epLength;
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft)} minutes free time.");
}
else
{
    double neededTime = epLength - brakeTimeLeft;
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(neededTime)} more minutes.");
}