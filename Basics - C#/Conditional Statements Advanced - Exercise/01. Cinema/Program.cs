string typeOfProjection =  Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double ticketPrice = 0.0;

if (typeOfProjection == "Premiere")
{
    ticketPrice = 12.00;
}
else if (typeOfProjection == "Normal")
{
    ticketPrice = 7.50;
}
else if (typeOfProjection == "Discount")
{
    ticketPrice = 5.00;
}

double fullPrice = ticketPrice * rows * columns;

Console.WriteLine($"{fullPrice:F2}");