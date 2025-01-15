int groups = int.Parse(Console.ReadLine());

string mountain = "";

int musSize = 0;
int montSize = 0;
int kiliSize = 0;
int k2Size = 0;
int everSize = 0;

for (int i = 0; i < groups; i++)
{
    int groupSize = int.Parse(Console.ReadLine());

    if (groupSize <= 5)
    {
        mountain = "Musala";
    }
    else if (groupSize <= 12)
    {
        mountain = "Montblanc";
    }
    else if (groupSize <= 25)
    {
        mountain = "Kilimanjaro";
    }
    else if (groupSize <= 40)
    {
        mountain = "K2";
    }
    else
    {
        mountain = "Everest";
    }

    if (mountain == "Musala")
    {
        musSize = musSize + groupSize;
    }
    else if (mountain == "Montblanc")
    {
        montSize = montSize + groupSize;
    }
    else if (mountain == "Kilimanjaro")
    {
        kiliSize = kiliSize + groupSize;
    }
    else if (mountain == "K2")
    {
        k2Size = k2Size + groupSize;
    }
    else if (mountain == "Everest")
    {
        everSize = everSize + groupSize;
    }
}

int fullSize = musSize + montSize + kiliSize + k2Size + everSize;

Console.WriteLine($"{musSize / (double)fullSize * 100:F2}%");
Console.WriteLine($"{montSize / (double)fullSize * 100:F2}%");
Console.WriteLine($"{kiliSize / (double)fullSize * 100:F2}%");
Console.WriteLine($"{k2Size / (double)fullSize * 100:F2}%");
Console.WriteLine($"{everSize / (double)fullSize * 100:F2}%");

