int n = int.Parse(Console.ReadLine());
int numCount = 1;

for (int row = 1; row <= n; row++)
{
    for(int col = 1; col <= row; col++)
    {
        Console.Write($"{numCount++} ");

        if (numCount > n)
        {
            break;
        }
    }
    if (numCount > n)
    {
        break;
    }
    Console.WriteLine();
}