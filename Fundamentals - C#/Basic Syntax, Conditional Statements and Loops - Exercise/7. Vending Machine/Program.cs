string command = Console.ReadLine();

double totalCoins = 0;

while (command != "Start")
{
    double coin = double.Parse(command);
    
    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
    {
        totalCoins += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }

    command = Console.ReadLine();
}

double nutsPrice = 2.0;
double waterPrice = 0.7;
double crispsPrice = 1.5;
double sodaPrice = 0.8;
double cokePrice = 1;


command = Console.ReadLine();
while (command != "End")
{
    if (command == "Nuts")
    {
        if (totalCoins >= 2)
        {
            totalCoins -= nutsPrice;
            Console.WriteLine("Purchased nuts");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Water")
    {
        if (totalCoins >= 0.7)
        {
            totalCoins -= waterPrice;
            Console.WriteLine("Purchased water");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Crisps")
    {
        if (totalCoins >= 1.5)
        {
            totalCoins -= crispsPrice;
            Console.WriteLine("Purchased crisps");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Soda")
    {
        if (totalCoins >= 0.8)
        {
            totalCoins -= sodaPrice;
            Console.WriteLine("Purchased soda");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (command == "Coke")
    {
        if (totalCoins >= 1)
        {
            totalCoins -= cokePrice;
            Console.WriteLine("Purchased coke");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }

    command = Console.ReadLine();
}

Console.WriteLine($"Change: {totalCoins:f2}");