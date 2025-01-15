int i = int.Parse(Console.ReadLine());

while (i % 2 != 0 || i == 0)
{
    Console.WriteLine("Please write an even number.");

    i = int.Parse(Console.ReadLine());
}

if (i % 2 == 0)
{
    Console.WriteLine($"The number is: {Math.Abs(i)}");
}