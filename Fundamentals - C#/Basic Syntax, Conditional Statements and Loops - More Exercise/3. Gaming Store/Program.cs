namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double remainingBudget = budget;

            while (command != "Game Time")
            {

                if (remainingBudget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                if (command == "OutFall 4")
                {
                    if (remainingBudget >= 39.99)
                    {
                        remainingBudget = remainingBudget - 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "CS: OG")
                {
                    if (remainingBudget >= 15.99)
                    {
                        remainingBudget = remainingBudget - 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (remainingBudget >= 19.99)
                    {
                        remainingBudget = remainingBudget - 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Honored 2")
                {
                    if (remainingBudget >= 59.99)
                    {
                        remainingBudget = remainingBudget - 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (remainingBudget >= 29.99)
                    {
                        remainingBudget = remainingBudget - 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (remainingBudget >= 39.99)
                    {
                        remainingBudget = remainingBudget - 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                command = Console.ReadLine();
            }

            if (remainingBudget != 0)
            {
            Console.WriteLine($"Total spent: ${budget - remainingBudget:f2}. Remaining: ${remainingBudget:f2}");
            }
        }
    }
}
