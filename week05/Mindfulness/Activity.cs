using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($" --- {_name} ---");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long, in seconds, would you like for your session?  ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
             Console.WriteLine("Please enter a positive number: ");
        }
        Console.WriteLine("Get ready......");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }
    }



}