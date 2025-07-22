using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture ("John 3:16",
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. ");
       
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            var userInput = Console.ReadLine();

            if (userInput?.ToLower() == "quit")
                break;
            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nCongratulations! You have memorized the scripture.");
                break;
            }
        }
    }
}