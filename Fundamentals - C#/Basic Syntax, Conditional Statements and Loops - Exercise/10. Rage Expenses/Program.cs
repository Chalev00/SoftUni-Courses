namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int headsetTrashCount = 0;
            int mouseTrashCount = 0;
            int keyboardTrashCount = 0;
            int displayTrashCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashCount++;
                }

                if (i % 3 == 0)
                {
                    mouseTrashCount++;
                }

                if (i % 6 == 0)
                {
                    keyboardTrashCount++;
                }

                if (i % 12 == 0)
                {
                    displayTrashCount++;
                }
            }

            double headsetExpenses = headsetTrashCount * headsetPrice;
            double mouseExpenses = mouseTrashCount * mousePrice;
            double keyboardExpenses = keyboardTrashCount * keyboardPrice;
            double displayExpenses = displayTrashCount * displayPrice;

            double totalExpenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
