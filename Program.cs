using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

        for(int i = 1; i <= 4; i++){
            Console.Clear();
            Console.WriteLine("Guess the secret number...");
            Console.Write($"Attempt {i}/4: ");
            string input = Console.ReadLine();
            int parsedInput = int.Parse(input);
            if (parsedInput == secretNumber)
            {
                Console.WriteLine("You guessed right, the secret number is 42!");
                break;
            }
            if(i != 4 && parsedInput != secretNumber)
                Console.WriteLine($"{parsedInput} is not the secret number, try again!");

            if(i == 4 && parsedInput != secretNumber)
            {
                Console.WriteLine("Better luck next time!");
            }
        }
        }
    }
}
