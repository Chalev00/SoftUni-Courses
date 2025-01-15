int floorCount = int.Parse(Console.ReadLine());
int roomCount = int.Parse(Console.ReadLine());

for (int y = floorCount; y >= 1; y--)
{
    for (int x = 0; x < roomCount; x++)
    {
        if (y == floorCount)
        {
            Console.Write($"L{y}{x} ");
        }
        else if (y % 2 != 0)
        {
            Console.Write($"A{y}{x} ");
        }
        else
        {
            Console.Write($"O{y}{x} ");
        }
    }
    Console.WriteLine();
}