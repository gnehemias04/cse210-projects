
/*
Author: Gabriel Nehemias Rengifo Krunfli
Excedding the requirements:
Difficulty selection: I add an option to select what kind of difficulty the user wants; 
if they select easy there will be two words hidden, if medium three and if hard five.
validation, I add validation to the inputs from the user to avoid problembs with invalid values.
scruptures: I add five scriptures that the user could select to memorize. alse there is a nice menu where
the user can interact with the program.  
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // first scripture
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // second scripture
        Reference reference2 = new Reference("1 Nephi", 3, 7);
        Scripture scripture2 = new Scripture(reference2, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        // third scripture
        Reference reference3 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture3 = new Scripture(reference3, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.");
        // fourth scripture
        Reference reference4 = new Reference("Alma", 37, 37);
        Scripture scripture4 = new Scripture(reference4, "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");
        // fifth scripture
        Reference reference5 = new Reference("John", 3, 5);
        Scripture scripture5 = new Scripture(reference5, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        string finish = "";
        string option = "";
        int numberToHide = 2;

        Scripture newScripture = null;

        // menu
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!\n\n");
        Console.WriteLine("Chosse a Scripture: ");
        Console.WriteLine("1. John 3:16 \n2. 1 Nephi 3:7 \n3. Proverbs 3:5-6 \n4. Alma 37:37 \n5. John 3:5 \n\n0. Exit");

        while (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "0" && option != "quit")
        {
            option = Console.ReadLine();
            if (option == "1")
            {

                newScripture = scripture1;
            }
            else if (option == "2")
            {

                newScripture = scripture2;
            }
            else if (option == "3")
            {

                newScripture = scripture3;
            }
            else if (option == "4")
            {

                newScripture = scripture4;
            }
            else if (option == "5")
            {

                newScripture = scripture5;
            }
            else if (option == "0" || option == "quit" || option == "exit")
            {
                finish = "quit";
                return;

            }
            else
            {
                Console.WriteLine("Invalid input, try again: ");

            }
        }
        Console.Clear();

        Console.WriteLine("Select difficulty: \n");
        Console.WriteLine("1. Easy (Hide 2 words) \n2.Medium(Hide 3 words) \n3.Hard(Hide 5 words)");
        string number = Console.ReadLine();
        if (number == "1")
        {
            numberToHide = 2;
        }
        else if (number == "2")
        {
            numberToHide = 3;
        }
        else if (number == "3")
        {
            numberToHide = 5;
        }
        else
        {
            numberToHide = 2;
            // if the user input a invalid valeu just keep going in easy mode
        }
        Console.Clear();



        while (finish != "quit" && newScripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine("");
            Console.WriteLine(newScripture.GetDisplayText());

            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            finish = Console.ReadLine();
            Console.Clear();
            if (finish != "quit")
            {
                newScripture.HideRandomWords(numberToHide);
            }


        }

        Console.WriteLine("Finished");


    }
}