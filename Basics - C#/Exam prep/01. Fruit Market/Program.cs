double strawberryPrice = double.Parse(Console.ReadLine());
double bananaKG = double.Parse(Console.ReadLine());
double orangeKG = double.Parse(Console.ReadLine());
double raspberryKG = double.Parse(Console.ReadLine());
double strawberryKG = double.Parse(Console.ReadLine());

double realStrawberryPrice = strawberryPrice * strawberryKG;

double raspberryPrice = strawberryPrice / 2;
double realRaspberryPrice = raspberryPrice * raspberryKG;

double orangePrice = raspberryPrice * 0.6;
double realOrangePrice = orangePrice * orangeKG;

double bananaPrice = raspberryPrice * 0.2;
double realBananaPrice = bananaPrice * bananaKG;



double finalPrice = realStrawberryPrice + realRaspberryPrice + realOrangePrice + realBananaPrice;

Console.WriteLine($"{ finalPrice:f2}");
