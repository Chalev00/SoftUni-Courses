﻿int n = int.Parse(Console.ReadLine());

int oddSum = 0;
int evenSum = 0;

for (int i = 1; i <= n; i++)
{
    int element = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        evenSum += element;
    }
    else
    {
        oddSum += element;
    }
}

if (oddSum == evenSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
}