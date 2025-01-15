string word = Console.ReadLine();

int sum = 0;

for (int n = 0; n < word.Length; n++)
{
    switch (word[n])
    {
        case 'a':
            sum += 1;
            break;
        case 'e':
            sum += 2;
            break;
        case 'i':
            sum += 3;
            break;
        case 'o':
            sum += 4;
            break;
        case 'u':
            sum += 5;
            break;
    }
}

Console.WriteLine(sum);
