﻿int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 0; i < tabs; i++)
{
    string webSiteName = Console.ReadLine();

    if (webSiteName == "Facebook")
    {
        salary -= 150;
    }
    else if (webSiteName == "Instagram")
    {
        salary -= 100;
    }
    else if (webSiteName == "Reddit")
    {
        salary -= 50;
    }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}
if (salary > 0)
{
    Console.WriteLine(salary);
}