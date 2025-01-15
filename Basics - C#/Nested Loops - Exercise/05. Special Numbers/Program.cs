int num = int.Parse(Console.ReadLine());

for (int i = 1; i < 9; i++)
{
    for (int o = 1; o < 9; o++)
    {
        for (int p = 1; p < 9; p++)
        {
            for (int u = 1; u < 9; u++)
            {
                if (num % i == 0 && num % o == 0 && num % p == 0 && num % u == 0)
                {
                    Console.Write($"{i}{o}{p}{u} ");
                }
            }
        }
    }
}