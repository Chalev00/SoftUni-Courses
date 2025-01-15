using System.Diagnostics.Metrics;
using System.Security.Authentication;

namespace _5._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            char letter;

            string words = "";

            while (input > 0)
            {

                int num = int.Parse(Console.ReadLine());

                string numToString = num.ToString();

                int digitLength = numToString.Length;

                int mainDigit = num % 10;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 ||mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = (offset + digitLength - 1);

                letter = (char)(97 + letterIndex);

                if (num == 0)
                {
                    letter = (char)(32);
                }

                words = words + letter;

                input--;

                if (input == 0)
                {
                    Console.WriteLine(words);
                }
            }
        }
    }
}
