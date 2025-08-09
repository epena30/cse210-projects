using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                new BreathingActivity().Run();
                break;
                case "2":
                new ListingActivity().Run();
                break;
                case "3":
                new ReflectingActivity().Run();
                break;
                case "4":
                Console.WriteLine("Goodbye!");
                return;
        }

            Console.WriteLine("\nPress enter to return to the menu....");
            Console.ReadLine();
        }

        }
    }

