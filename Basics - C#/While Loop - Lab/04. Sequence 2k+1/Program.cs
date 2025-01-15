int n  = int.Parse(Console.ReadLine());

int n2 = 1;
while (n >= n2)
{
    Console.WriteLine(n2);
    n2 = (n2 * 2) + 1;
}