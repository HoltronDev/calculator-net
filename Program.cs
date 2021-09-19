using System;

namespace calculator_net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator. Type 'exit' or use ctrl+c to exit.");
            Console.WriteLine("This application is capable of the following operations.");
            Console.WriteLine("X + Y");
            Console.WriteLine("X - Y");
            Console.WriteLine("X * Y");
            Console.WriteLine("X / Y");
            Console.WriteLine("Operations must be space separated.");

            string input = "";
            while(input != "exit")
            {
                input = Console.ReadLine();

                if(input == "exit")
                {
                    continue;
                }

                var parts = input.Split(' ');
                if(parts.Length != 3)
                {
                    Console.WriteLine("Invalid input, not enough arguments. Try again.");
                    continue;
                }

                if(!decimal.TryParse(parts[0], out var first))
                {
                    Console.WriteLine("Invalid input for the first number, try again.");
                    continue;
                }

                if(!decimal.TryParse(parts[2], out var second))
                {
                    Console.WriteLine("Invalid input for the second number, try again.");
                    continue;
                }

                switch(parts[1])
                {
                    case "+":
                        Console.WriteLine($"Answer: {first + second}");
                        break;
                    case "-":
                        Console.WriteLine($"Answer: {first - second}");
                        break;
                    case "*":
                        Console.WriteLine($"Answer: {first * second}");
                        break;
                    case "/":
                        Console.WriteLine($"Answer: {first / second}");
                        break;
                    default:
                        Console.WriteLine($"The operation {parts[1]} is unsupported. Try again.");
                        break;
                }
            }
        }
    }
}
