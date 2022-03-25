namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "exit" && input != "kraj") {
                string[] arguments = input.Split();
                if (arguments.Length != 3) {
                    Console.WriteLine("Neispravan ulaz!");
                } else {
                    double n1 = double.Parse(arguments[0]);
                    double n2 = double.Parse(arguments[2]);
                    double result = n1 + n2;
                    Console.WriteLine(n1 + " + " + n2 + " = " + result);
                }
                input = Console.ReadLine();
            }
        }
    }
}