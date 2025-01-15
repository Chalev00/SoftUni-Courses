int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int fullsize = width * length;

int pieces = 0;

string command = Console.ReadLine();

bool isCakeFinished = false;

while (command != "STOP")
{
    pieces = int.Parse(command);

    fullsize -= pieces;

    if (fullsize <= 0)
    {
        isCakeFinished = true;
        break;
    }
    else

    command = Console.ReadLine();
}

if (isCakeFinished)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(fullsize)} pieces more.");
}
else
{
    Console.WriteLine($"{fullsize} pieces are left.");
}

