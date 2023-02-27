using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            Console.WriteLine("Guess the secret number...");
            string input = Console.ReadLine();
            int parsedInput = int.Parse(input);
            if (parsedInput == secretNumber)
            {
                Console.WriteLine("You guessed right, the secret number is 42!");
            }
            else 
            Console.WriteLine($"{parsedInput} is not the secret number, try again!");
        }
    }
}
