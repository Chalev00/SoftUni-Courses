﻿int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

for (int num = firstNum; num <= secondNum; num++)
{
    string currentNum = num.ToString();
    int oddSum = 0;
    int evenSum = 0;

    for (int i = 0; i < currentNum.Length; i++)
    {
        if (i % 2 == 0)
        {
            evenSum += currentNum[i];
        }
        else
        {
            oddSum += currentNum[i];
        }
    }

    if (oddSum == evenSum)
    {
        Console.Write($"{currentNum} ");
    }
}