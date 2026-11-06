using System;

class Program
{
    static void Main(string[] args)

    {
        string playAgain = "yes";
        while (playAgain == "yes" || playAgain == "YES" || playAgain == "Yes" || playAgain == "yeah")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            bool guessed = false;
            int guesses = 0;


            while (guessed == false)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                int guessNumer = int.Parse(guess);
                guesses = guesses + 1;

                if (guessNumer == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    guessed = true;
                }
                else if (guessNumer > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumer < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }

            Console.WriteLine($"You guessed it in {guesses} times! Congratulations!!");
            Console.WriteLine("Do you want to play again? yes/not");
            playAgain = Console.ReadLine();
        }
    }
}