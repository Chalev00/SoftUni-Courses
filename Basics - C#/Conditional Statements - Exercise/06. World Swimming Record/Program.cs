double recordInSecs = double.Parse(Console.ReadLine());
double distanceInMtrs = double.Parse(Console.ReadLine());
double mtrsInSecs = double.Parse(Console.ReadLine());

double swimmingTime = distanceInMtrs * mtrsInSecs;

double delayedTime = Math.Floor(distanceInMtrs / 15);
double totalTime = swimmingTime + delayedTime * 12.5;

if (totalTime < recordInSecs)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    double failedTime = totalTime - recordInSecs;
    Console.WriteLine($"No, he failed! He was {failedTime:F2} seconds slower.");
}