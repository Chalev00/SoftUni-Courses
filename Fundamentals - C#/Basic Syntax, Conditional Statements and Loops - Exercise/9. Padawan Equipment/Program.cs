namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLightsaberPrice = lightsaberPrice * (Math.Ceiling(count * 1.1));
            double totalRobePrice = robePrice * count;

            int beltCount = count;

            for (int i = 1; i <= count; i++)
            {
                if (i % 6 == 0)
                {
                    beltCount = beltCount - 1;
                }
            }
            double totalBeltPrice = beltPrice * beltCount;

            double totalPrice = totalLightsaberPrice + totalRobePrice + totalBeltPrice;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:F2}lv more.");
            }
        }
    }
}
