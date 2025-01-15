int minNum = int.MaxValue;
string input = Console.ReadLine();

while (input != "Stop")
{
    int num = int.Parse(input);

    if (num < minNum)
    {
        minNum = num;
    }

    input = Console.ReadLine();
}

Console.WriteLine(minNum);