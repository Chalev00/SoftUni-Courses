string input = Console.ReadLine();

int studentTickets = 0;
int standardTickets = 0;
int kidsTickets = 0;

while (input != "Finish")
{
    string filmName = input;
    int freeTickets = int.Parse(Console.ReadLine());
    int buyTickets = 0;

    string ticket = Console.ReadLine();

    while (ticket != "End")
    {
        switch (ticket)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidsTickets++;
                break;
        }
        buyTickets++;

        if (buyTickets == freeTickets)
        {
            break;
        }

        ticket = Console.ReadLine();
    }

    Console.WriteLine($"{filmName} - {(double)buyTickets / freeTickets * 100:f2}% full.");

    input = Console.ReadLine();
}

int totalTickets = studentTickets + standardTickets + kidsTickets;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kidsTickets / totalTickets * 100:f2}% kids tickets.");