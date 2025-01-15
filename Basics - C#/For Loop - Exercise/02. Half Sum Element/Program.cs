int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxNum = int.MinValue;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > maxNum)
    {
        maxNum = num;
    }
    sum = sum + num;
}

int wholeSum = sum - maxNum;

if (wholeSum == maxNum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {wholeSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(maxNum - wholeSum)}");
}

