using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "If you could change one thing about today, what would it be?",
            "What made you laugh or smile most today?",
            "Who upset you most today and why?",
            "What was the most interesting thing someone said to you today?",
            "What was the coolest thing you learned today?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}