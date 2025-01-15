int maxNum = int.MinValue;
string input = Console.ReadLine();

while (input != "Stop")
{
    int num = int.Parse(input);

    if (num > maxNum)
    {
        maxNum = num;
    }

    input = Console.ReadLine();
}

Console.WriteLine(maxNum);