int number = int.Parse(Console.ReadLine());
int inputSum = 0;

while (inputSum < number)
{
    inputSum += int.Parse(Console.ReadLine());
}

Console.WriteLine(inputSum);

