using System.Data;

int placeWidth = int.Parse(Console.ReadLine());
int placeLength = int.Parse(Console.ReadLine());
int placeHeight = int.Parse(Console.ReadLine());

int freeSpace = placeWidth * placeLength * placeHeight;

string command = Console.ReadLine();
int boxes = 0;
int boxesSum = 0;
bool isSpaceFinished = false;

while (command != "Done") 
{
    boxes = int.Parse(command);
    boxesSum += boxes;

    if (boxesSum > freeSpace)
    {
        isSpaceFinished = true;
        break;
    }

    command = Console.ReadLine();
}
if (isSpaceFinished)
{
    Console.WriteLine($"No more free space! You need {boxesSum - freeSpace} Cubic meters more.");
}
else
{
    Console.WriteLine($"{freeSpace - boxesSum} Cubic meters left.");
}