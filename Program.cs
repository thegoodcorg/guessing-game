using System;

namespace guessingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("~~ Guessing Game!~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Select a difficulty");
            Console.WriteLine("1 for Easy (8 guesses)");
            Console.WriteLine("2 for Easy (6 guesses)");
            Console.WriteLine("3 for Easy (4 guesses)");
            int difficulty = int.Parse(Console.ReadLine());
             int guesses = 0;
            if (difficulty == 1)
            {
                guesses = 8;
            }
            if (difficulty == 2)
            {
                guesses = 6;
            }
            if (difficulty == 3)
            {
                guesses = 4;
            }
        
            Console.Clear();
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 100);

            for (int i = 1; i <= guesses; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Guess the secret number...");
                }
                Console.Write($"Attempt {i}/{guesses}: ");
                string input = Console.ReadLine();
                Console.Clear();
                int parsedInput = int.Parse(input);
                if (parsedInput == secretNumber)
                {
                    Console.WriteLine($"The correct answer is {secretNumber}!");
                    Console.WriteLine("Conglaturations, a winner is you!");
                    break;
                }
                if (i != guesses && parsedInput != secretNumber)
                    if (secretNumber < parsedInput)
                    {
                        Console.WriteLine($"{parsedInput} is to high! guess lower");
                    }
                if (secretNumber > parsedInput)
                {
                    Console.WriteLine($"{parsedInput} is to low! guess higher");
                }

                if (i == guesses && parsedInput != secretNumber)
                {
                    Console.WriteLine($"You lose. The number was {secretNumber}. Better luck next time!");
                }
            }
        }
    }
}
