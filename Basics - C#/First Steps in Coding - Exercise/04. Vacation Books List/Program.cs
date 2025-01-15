int numPages = int.Parse(Console.ReadLine());
int pagesReadFor1H = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hours = numPages / pagesReadFor1H;
int neededHoursPerDay = hours / days;

Console.WriteLine(neededHoursPerDay);