int tournamentCount = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

int totalPoints = 0;
double wonTournaments = 0;

for (int i = 0; i < tournamentCount; i++)
{
    string tournamentPlace = Console.ReadLine();

    switch (tournamentPlace)
    {
        case "W":
            totalPoints += 2000;
            wonTournaments += 1;
            break;
        case "F":
            totalPoints += 1200;
            break;
        case "SF":
            totalPoints += 720;
            break;
    }
}

double averagePoints = totalPoints / tournamentCount;
int finalPoints = totalPoints + startingPoints;
double percentWins = wonTournaments / tournamentCount * 100;


Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percentWins:F2}%");