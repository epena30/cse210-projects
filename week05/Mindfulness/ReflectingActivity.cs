using System;
using System.Collections.Generic;


class ReflectingActivity : Activity
{ 
     private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help youreflect on times in your life when you have shown strength and resilience. This willhelp you recognize the power you have and how you can use it in other aspects ofyour life. ";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything lid this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not assuccessful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }
        
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(10);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];

    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
       
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider the follow promtp:");
        Console.WriteLine($"----{prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following question as they realte to this exercise");

    }

    public void DisplayQuestions()
    {
        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}

