string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int referees = int.Parse(Console.ReadLine());

for (int i = 1; i <= referees; i++)
{
    string refName = Console.ReadLine();
    double refPoints = double.Parse(Console.ReadLine());

    points += ((refName.Length * refPoints) / 2);
    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
        break;
    }
}
if (points < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:F1} more!");
}