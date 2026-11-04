using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magicNumber = int.Parse(magic);
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