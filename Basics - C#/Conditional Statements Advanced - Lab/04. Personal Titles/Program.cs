﻿double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (age < 16) {
    if (gender == 'f')
    {
        Console.WriteLine("Miss");
    }
    else if (gender == 'm') 
    {
        Console.WriteLine("Master");
    }
}
else if (age >= 16)
{
    if (gender == 'f')
    {
        Console.WriteLine("Ms.");
    }
    else if (gender == 'm')
    {
        Console.WriteLine("Mr.");
    }
}