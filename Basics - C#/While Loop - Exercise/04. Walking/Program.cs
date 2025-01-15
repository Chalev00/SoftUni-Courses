using System.Data;

int totalSteps = 0;

string input = Console.ReadLine();
bool isGoalReached = false;

while (input != "Going home")
{
    int steps = int.Parse(input);
    totalSteps += steps;

    if (totalSteps >= 10000)
    {
        isGoalReached = true;
        break;
    }

    input = Console.ReadLine();
}

if (!isGoalReached)
{
    int steps = int.Parse(Console.ReadLine());
    totalSteps += steps;

    if (totalSteps >= 10000)
    {
        isGoalReached = true;
    }
}

if (isGoalReached)
{
    Console.WriteLine($"Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
}
else
{
    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
}
