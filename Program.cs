using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rnd = new Random();
            int secretNumber = rnd.Next(1,100);

        for(int i = 1; i <= 4; i++){
            if(i == 1){
            Console.WriteLine("Guess the secret number...");
            }
            Console.Write($"Attempt {i}/4: ");
            string input = Console.ReadLine();
            Console.Clear();
            int parsedInput = int.Parse(input);
            if (parsedInput == secretNumber)
            {
                Console.WriteLine($"The correct answer is {secretNumber}!");
                Console.WriteLine("Conglaturations, a winner is you!");
                break;
            }
            if(i != 4 && parsedInput != secretNumber)
                if(secretNumber < parsedInput){
                    Console.WriteLine($"{parsedInput} is to high! guess lower");
                }
                if(secretNumber > parsedInput){
                    Console.WriteLine($"{parsedInput} is to low! guess higher");
                }

            if(i == 4 && parsedInput != secretNumber)
            {
                Console.WriteLine($"You lose. The number was {secretNumber}. Better luck next time!");
            }
        }
        }
    }
}
