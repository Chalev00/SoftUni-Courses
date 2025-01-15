int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int realMins = minutes + 30;

if (realMins > 60)
{
    realMins = realMins - 60;
    hours = hours + 1;

    if (hours > 23)
    {
        hours = 0;
    }
}

if (realMins < 10)
{
    Console.WriteLine($"{hours}:0{realMins}");
}
else
{
    Console.WriteLine($"{hours}:{realMins}");
}