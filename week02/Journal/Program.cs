using System;

class Program
{
    static void Main(string[] args)
    {
         
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool quit = false;

        Console.WriteLine("Welcome to My Journal Program! ");
        
        while (!quit)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?  ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    Console.WriteLine("\n--- Journal Entries ---");
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter file to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter file to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again. ");
                    break;

            }

        }
        Console.WriteLine("Thanks for using My Journal! Goodbye!");

        }
    }
