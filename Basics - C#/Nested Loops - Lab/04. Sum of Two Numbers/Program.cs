int intOne = int.Parse(Console.ReadLine());
int intTwo = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int combination = 0;

bool isComboFound = false;

for (int x = intOne; x <= intTwo; x++)
{
    for (int y = intOne; y <= intTwo ; y++)
    {
        combination++;
    
        if (x + y == magicNum)
        {
            Console.WriteLine($"Combination N:{combination} ({x} + {y} = {magicNum})");

            isComboFound = true;

            break;
        }
    }
if (isComboFound)
    {
        break;
    }

}
if (!isComboFound)
{
    Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
}