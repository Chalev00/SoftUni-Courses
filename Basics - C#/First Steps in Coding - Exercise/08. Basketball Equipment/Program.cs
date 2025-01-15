double yearlyTax = double.Parse(Console.ReadLine());

double shoes = yearlyTax - (yearlyTax * 0.4);
double jersey = shoes - (shoes * 0.20);
double ball = jersey - (jersey * 0.75);
double accessories = ball - (ball * 0.8);

double finalPrice = yearlyTax + shoes + jersey + ball + accessories;

Console.WriteLine(finalPrice);
