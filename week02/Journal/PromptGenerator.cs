using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    public Random random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "What challenges did you face today and how did you handle them?",
            "What did you do today to take care of yourself?",
            "What was the most interesting thing you saw or heard today?",
            "How did you connect with others today?"
        };
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}


