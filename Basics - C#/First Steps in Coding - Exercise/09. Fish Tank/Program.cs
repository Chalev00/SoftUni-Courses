int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentTaken = double.Parse(Console.ReadLine()) / 100;

int aquariumSize = length * width * height;
double aquariumCapacity = (double)aquariumSize / 1000;
double neededLt = aquariumCapacity * (1 - percentTaken);

Console.WriteLine(neededLt);