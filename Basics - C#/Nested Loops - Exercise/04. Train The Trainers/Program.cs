int refs = int.Parse(Console.ReadLine());

string presentaion = Console.ReadLine();

double finalMark = 0;

int count = 0;
while (presentaion != "Finish")
{
    count++;

    double mark = 0;
    for (int i = 1; i <= refs; i++)
    {
       mark += double.Parse(Console.ReadLine());
    }
    mark = mark / refs;
    finalMark += mark;

    Console.WriteLine($"{presentaion} - {mark:f2}.");
    
    presentaion = Console.ReadLine();
}

finalMark /= count;
Console.WriteLine($"Student's final assessment is {finalMark:f2}.");