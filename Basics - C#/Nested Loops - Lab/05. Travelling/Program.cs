while (true)
{
    string destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    int vacMoney = int.Parse(Console.ReadLine());
    int savedMoneySum = 0;

    while (savedMoneySum < vacMoney)
    {
        int SavedMoney = int.Parse(Console.ReadLine());
        savedMoneySum += SavedMoney;
    }
    if (savedMoneySum >= vacMoney)
    {
        Console.WriteLine($"Going to {destination}!");
    }
}