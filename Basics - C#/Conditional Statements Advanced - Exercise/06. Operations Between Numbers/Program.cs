using System.Runtime.Intrinsics.X86;

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

int result = 0;


if (operation == '+' || operation == '-' || operation == '*')
{
    switch (operation)
    {
        case '+':
            result = n1 + n2;
            break;
        case '-':
            result = n1 - n2;
            break;
        case '*':
            result = n1 * n2;
            break;
    }
    if (result % 2 == 0)
    {
        Console.WriteLine($"{n1} {operation} {n2} = {result} - even");
    }
    else if (result % 2 != 0)
    {
        Console.WriteLine($"{n1} {operation} {n2} = {result} - odd");
    }
}
else
{
    if (n2 == 0)
    {
        Console.WriteLine($"Cannot divide {n1} by zero");
    }
    else if (operation == '/')
    {
        Console.WriteLine($"{n1} / {n2} = {(double)n1 / n2:F2}");
    }
    else if (operation == '%')
    {
        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
    }

}
