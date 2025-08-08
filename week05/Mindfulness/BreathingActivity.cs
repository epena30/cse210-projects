using System;
using System.Collections.Generic;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "BreathingActivity";
        _description =  "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(4);
            elapsed += 5;
            if (elapsed >= _duration) break;

            Console.WriteLine("Breath out....");
            ShowCountDown(5);
            elapsed += 5;
        }
        DisplayEndingMessage();
    }
}

