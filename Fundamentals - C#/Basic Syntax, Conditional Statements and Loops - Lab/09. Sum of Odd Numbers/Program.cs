int n = int.Parse(Console.ReadLine());
int sumOfOdd = 0;
int num = 0;


while (n > 0)
{
    if (num % 2 != 0)
    {
        Console.WriteLine(num);
        sumOfOdd += num;
        n--;
    }

    num++;

}

Console.WriteLine($"Sum: {sumOfOdd}");