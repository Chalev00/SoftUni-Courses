string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

int timeToComplete = projects * 3;

Console.WriteLine($"The architect {name} will need {timeToComplete} hours to complete {projects} project/s.");
