int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

if (minutes >= 45)
{
    minutes = (minutes + 15) % 60;
    hour += 1;
}
else
{
    minutes = minutes + 15;
}

if (hour == 24) 
{
    hour = 0;
}

if (minutes < 10)
{
    Console.WriteLine($"{hour}:0{minutes}");
}
else
{
    Console.WriteLine($"{hour}:{minutes}");
}