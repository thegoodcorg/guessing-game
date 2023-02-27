using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number...");
            string input = Console.ReadLine();
            Console.WriteLine($"You guessed {input}");
        }
    }
}
