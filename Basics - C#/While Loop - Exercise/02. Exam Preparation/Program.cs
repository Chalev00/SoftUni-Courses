int badGradeMax = int.Parse(Console.ReadLine());

bool isLimitReached = false;
string command = Console.ReadLine();
int badGradeCount = 0;
int gradeSum = 0;
int gradeCount = 0;
string lastProblem = "";

while (command != "Enough")
{
    int grade = int.Parse(Console.ReadLine());
    gradeCount++;
    gradeSum += grade;

    if (grade <= 4)
    {
        badGradeCount++;
    }
    if (badGradeCount >= badGradeMax)
    {
        isLimitReached = true;
        break;
    }

    lastProblem = command;
    command = Console.ReadLine();

}
if (isLimitReached)
{
    Console.WriteLine($"You need a break, {badGradeCount} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {(double)gradeSum / gradeCount:F2}");
    Console.WriteLine($"Number of problems: {gradeCount}");
    Console.WriteLine($"Last problem: {lastProblem}");
}