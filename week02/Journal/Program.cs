using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        string option = "";

        Console.WriteLine("Welcome to the Journal Program!");
        while (option != "5")
        {

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            option = Console.ReadLine();
            if (option == "1" || option == "Write" || option == "write")
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string question = prompt.GetRandomPrompt();
                Console.WriteLine(question);
                string response;
                response = Console.ReadLine();
                Entry entry = new Entry(dateText, question, response);
                journal.AddEntry(entry);

            }
            else if (option == "2" || option == "Display" || option == "display")
            {
                journal.DisplayAll();
            }
            else if (option == "3" || option == "Load" || option == "load")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (option == "4" || option == "Save" || option == "save")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (option == "5" || option == "Quit" || option == "quit")
            {
                Console.WriteLine("See you!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }


        }

    }
}