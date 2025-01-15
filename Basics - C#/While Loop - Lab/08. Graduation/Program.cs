string name = Console.ReadLine();

int clas = 1;
double avgGrade = 0;

int failedTimes = 0;

while (clas <= 12)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade < 4)
    {
        failedTimes++;
        if (failedTimes == 2)
        {
            Console.WriteLine($"{name} has been excluded at {clas} grade");
            break;
        }

        continue;
    }

    clas++;
    avgGrade += grade;
}
if (clas > 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {avgGrade / 12:F2}");
}