double nylon = 1.50;
double paint = 14.50;
double thinner = 5.00;

int reqNylon = int.Parse(Console.ReadLine());
int reqPaint = int.Parse(Console.ReadLine());
int reqThinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double allNylon = (reqNylon + 2) * nylon;
double allPaint = (reqPaint + (reqPaint * 0.10)) * paint;
double allThinner = thinner * reqThinner;

double bags = 0.40;

double fullPrice = allNylon + allPaint + allThinner + bags;

double hourlyWage = (fullPrice - (fullPrice * 0.7)) * hours;

double finalPrice = fullPrice + hourlyWage;

Console.WriteLine(finalPrice);