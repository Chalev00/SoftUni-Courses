using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());

int sumLeft = 0;
int sumRight = 0;
for (int i = 0; i < n; i++)
{
    int leftNumbers = int.Parse(Console.ReadLine());
    sumLeft += leftNumbers;
}
for (int i = 0; i < n; i++)
{
    int rightNumbers = int.Parse(Console.ReadLine());
    sumRight += rightNumbers;
}

if (sumRight == sumLeft)
{
    Console.WriteLine($"Yes, sum = {sumRight}");
}
else
{
    int diff = sumRight - sumLeft;
    Console.WriteLine($"No, diff = {Math.Abs(diff)}");
}