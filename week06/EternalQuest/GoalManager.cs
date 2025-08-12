using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Types of Goals are:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Player Info");
            Console.WriteLine("4. List Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Select a choice from the menu");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;

                case "3":
                    DisplayPlayerInfo();
                    break;

                case "4":
                    ListGoals();
                    break;

                case "5":
                    SaveGoals();
                    break;

                case "6":
                    LoadGoals();
                    break;

                case "7":
                    running = false;
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create? ");
        string number = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is the short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points asssociated with ths goal? ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose Goal Type");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalType = Console.ReadLine();
        Goal goal = null;

        switch (goalType)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;

            case "2":
                goal = new EternalGoal(name, description, points);
                break;

            case "3":
                Console.WriteLine("Enter number of amount to completer: ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }
        if (goal != null)
        {
            _goals.Add(goal);
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("Goals list: ");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine("Saving goals to file....");
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");

    }
    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("File not found.");
            return;
        }
        Console.WriteLine("Loading goals from file....");
        _goals.Clear();
        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine())! = null)
            {
                var parts = line.Split(",");
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                var goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals laoded.");
    }
    public void RecordEvent()
    {
        Console.WriteLine("Record Evernt");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
        Console.WriteLine("Select a choice from the menu: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoints();
            Console.WriteLine("Event Recorded!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
}
