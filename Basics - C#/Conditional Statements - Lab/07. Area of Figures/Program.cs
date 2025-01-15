string shape = Console.ReadLine();

double area = 0;

if (shape == "square")
{
    double size = double.Parse(Console.ReadLine());
    area = Math.Pow(size, 2);
}
else if (shape == "rectangle")
{
    double length = double.Parse(Console.ReadLine());
    double width = double.Parse(Console.ReadLine());
    area = length * width;
}
else if (shape == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * Math.Pow(radius, 2);
}
else if (shape == "triangle")
{
    double baseTri = double.Parse(Console.ReadLine());
    double heightTri = double.Parse(Console.ReadLine());
    area = (baseTri / 2) * heightTri;
}

Console.WriteLine($"{area:F3}");