/*
Author: Gabriel Nehemias Rengifo Krunfli
Excedding the requirements:
Delete method: I added the delete method to delete any file the user choose to delete
Validations: I added validetions to the inputs from the user, in the Save method the user can't 
left the filename empty, also there are validations in the Load method, the filename can't be empty and if the filename
doesn't exist or is incorrect the program will show a message.
Empty response to the journal: I add a validation if the response is empty the user need to write again.
Prompts: I added the five prompts from the BYU Site and added more fifteen
*/






using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        string option = "";

        Console.WriteLine("Welcome to the Journal Program!");
        while (option != "6")
        {

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
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
                while (response == "" || response == " " || response == "  ")
                {
                    Console.WriteLine("The response can't be empty ");
                    Console.WriteLine("Write again");
                    response = Console.ReadLine();
                }
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
                while (filename == "")
                {
                    Console.WriteLine("The filename can't be empty ");
                    Console.WriteLine("What is the filename? ");
                    filename = Console.ReadLine();
                }
                if (File.Exists(filename + ".txt"))
                {
                    journal.LoadFromFile(filename);
                }
                else
                {
                    Console.WriteLine("This file doesn't exist or the filename is incorrect.");
                }

            }
            else if (option == "4" || option == "Save" || option == "save")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                while (filename == "")
                {
                    Console.WriteLine("The filename can't be empty ");
                    Console.WriteLine("What is the filename? ");
                    filename = Console.ReadLine();
                }

                journal.SaveToFile(filename);

            }
            else if (option == "5" || option == "Delete" || option == "delete")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string sure;
                while (filename == "")
                {
                    Console.WriteLine("The filename can't be empty ");
                    Console.WriteLine("What is the filename? ");
                    filename = Console.ReadLine();
                }
                if (File.Exists(filename + ".txt"))
                {
                    Console.WriteLine("Are you sure you want to delete this file? (yes/no)");
                    sure = Console.ReadLine();
                    if (sure == "yes" || sure == "Yes" || sure == "YES")
                    {
                        journal.DeleteFromFile(filename);
                        Console.WriteLine("Deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Delete canceled");
                    }

                }
                else
                {
                    Console.WriteLine("This file doesn't exist or the filename is incorrect.");
                }
            }
            else if (option == "6" || option == "Quit" || option == "quit")
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