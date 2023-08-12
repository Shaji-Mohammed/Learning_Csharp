// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, I'm a calculator.");
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Operations available: +, -, *, /, %");
        Console.Write("Please select one operation: ");
        string operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (operation == "+")
        {
            Console.WriteLine(num1 + num2);
        } else if (operation == "-")
        {
            Console.WriteLine(num1 - num2);
        } else if (operation == "*")
        {
            Console.WriteLine(num1 * num2);
        } else if (operation == "/") { 
            Console.WriteLine(num1 / num2);
        } else {
            Console.WriteLine(num1 % num2);
        }
    }
}
