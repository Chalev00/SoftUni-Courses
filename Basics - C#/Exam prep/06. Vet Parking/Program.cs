int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

//Start digits
int startFourthDigit = start % 10;
start = start / 10;

int startThirdDigit = start % 10;
start = start / 10;

int startSecondDigit = start % 10;
start = start / 10;

int startFirstDigit = start % 10;
start = start / 10;

//End digits
int endFourthDigit = end % 10;
end = end / 10;

int endThirdDigit = end % 10;
end = end / 10;

int endSecondDigit = end % 10;
end = end / 10;

int endFirstDigit = end % 10;
end = end / 10;


for (int i = startFirstDigit; i <= endFirstDigit; i++)
{
    for (int j = startSecondDigit;  j <= endSecondDigit; j++)
    {
        for (int k = startThirdDigit; k <= endThirdDigit; k++)
        {
            for (int l = startFourthDigit; l <= endFourthDigit; l++)
            {
                if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                {
                    Console.Write($"{i}{j}{k}{l} ");
                }
            }
        }
    }
}