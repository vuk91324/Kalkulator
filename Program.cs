namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "exit" && input != "kraj") {
                input = Console.ReadLine();
            }
        }
    }
}