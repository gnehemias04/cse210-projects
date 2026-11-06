using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);
        bool guessed = false;

        while (guessed == false)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumer = int.Parse(guess);

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

    }
}