int i = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

int j = 0;

while (j < 10)
{
    j++;

    if (j >= k)
    {
        Console.WriteLine($"{i} X {j} = {i * j}");
    }
}

if (k > 10)
{
    Console.WriteLine($"{i} X {k} = {i * k}");
}