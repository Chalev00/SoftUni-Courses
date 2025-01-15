namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int count = 0;
            
            for (int i = 1; i <= 4; i++) 
            {
                char[] reversePass = username.ToCharArray();
                Array.Reverse(reversePass);
                string reverse = new string(reversePass);

                string password = Console.ReadLine();

                count++;

                if (count > 3 && password != reverse)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else if (password == reverse)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (password != reverse && count <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
