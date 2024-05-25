using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts;
    private Random random;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "If you could change one thing about today, what would it be?",
            "What made you laugh or smile most today?",
            "Who upset you most today and why?",
            "What was the most interesting thing someone said to you today?",
            "What was the coolest thing you learned today?"
        };
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
