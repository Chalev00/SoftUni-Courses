double depositSum = double.Parse(Console.ReadLine());
int timeframe = int.Parse(Console.ReadLine());
double yearlyPercent = double.Parse(Console.ReadLine()) / 100;

double sum = depositSum + timeframe * ((depositSum * yearlyPercent) / 12);

Console.WriteLine(sum);