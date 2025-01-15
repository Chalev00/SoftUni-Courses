namespace _4._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string norm = Console.ReadLine();

            string reversed = new string(norm.Reverse().ToArray());

            Console.WriteLine(reversed);
        }
    }
}
