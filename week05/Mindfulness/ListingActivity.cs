using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help youreflect on the good things in your life by having you list as many things as you can ina certain area.";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {

        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("You will begin listing in a few seconds....");
        ShowCountDown(3);
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"\nYou listed {_count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList a many responses as you can to the following prompt: ");
        Console.WriteLine($"---- {prompt}---");         
       
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < _duration)
        {
            Console.WriteLine(">");
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    list.Add(input);
            }
        }
        return list;

    }
}