string day = Console.ReadLine();

int ticketPrice = 0;

if (day == "Monday" || day == "Tuesday" || day == "Friday")
{
    ticketPrice = 12;
}
else if (day == "Wednesday" || day == "Thursday")
{
    ticketPrice = 14;
}
else if (day == "Saturday" || day == "Sunday")
{
    ticketPrice = 16;
}

Console.WriteLine(ticketPrice);