int num = int.Parse(Console.ReadLine());

int original = num;

int sum = 0;

while (num > 0)
{
    int digits = num % 10;

    int fact = 1;

    for (int i = 1; i <= digits; i++)
    {
        fact = fact * i;
    }

    sum = sum + fact;

    num = num / 10;
}

if (sum == original)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}