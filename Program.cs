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
                    Console.WriteLine("Neispravan broj argumenata!");
                } else {
                    double n1 = double.Parse(arguments[0]);
                    double n2 = double.Parse(arguments[2]);
                    double result = -1;
                    Boolean err = false;
                    if (arguments[1] == "+") {
                        result = n1 + n2;
                    } else if (arguments[1] == "-") {
                        result = n1 - n2;
                    } else if (arguments[1] == "*") {
                        result = n1 * n2;
                    } else {
                        Console.WriteLine("Neispravan operator!");
                        err = true;
                    }
                    if (!err)
                        Console.WriteLine(n1 + " " + arguments[1] +" " + n2 + " = " + result);
                }
                input = Console.ReadLine();
            }
        }
    }
}