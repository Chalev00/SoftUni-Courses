namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double fullPrice = 0;
            double totalPrice = 0;

            while (orders > 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                fullPrice = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${fullPrice:F2}");

                orders--;
                totalPrice = totalPrice + fullPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");

        }
    }
}
