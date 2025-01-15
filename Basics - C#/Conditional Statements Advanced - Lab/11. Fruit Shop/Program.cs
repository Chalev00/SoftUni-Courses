using System.ComponentModel.Design;

string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double fruitPrice = 0;
bool isValid = true;

if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{
    switch (fruit){
        case "banana":
            fruitPrice = 2.50;
            break;
        case "apple":
            fruitPrice = 1.20;
            break;
        case "orange":
            fruitPrice = 0.85;
            break;
        case "grapefruit":
            fruitPrice = 1.45;
            break;
        case "kiwi":
            fruitPrice = 2.70;
            break;
        case "pineapple":
            fruitPrice = 5.50;
            break;
        case "grapes":
            fruitPrice = 3.85;
            break;
        default:
            Console.WriteLine("error");
            isValid = false;
            break;
    }
}
else if (day == "Saturday" || day == "Sunday")
{
    switch (fruit)
    {
        case "banana":
            fruitPrice = 2.70;
            break;
        case "apple":
            fruitPrice = 1.25;
            break;
        case "orange":
            fruitPrice = 0.90;
            break;
        case "grapefruit":
            fruitPrice = 1.60;
            break;
        case "kiwi":
            fruitPrice = 3.00;
            break;
        case "pineapple":
            fruitPrice = 5.60;
            break;
        case "grapes":
            fruitPrice = 4.20;
            break;
        default:
            Console.WriteLine("error");
            isValid = false;
            break;
    }
}
else
{
    Console.WriteLine("error");
    isValid = false;
}

if (isValid)
{
    double fullPrice = quantity * fruitPrice;
    Console.WriteLine($"{fullPrice:F2}");
}