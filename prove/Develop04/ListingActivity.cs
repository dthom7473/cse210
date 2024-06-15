using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ListingActivity : Activities
{
    private static readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int durParam, string nameParam, string descriptionParam)
        : base(durParam, nameParam, descriptionParam) //just refer to parent
    {
        // No additional initialization required
    }

    public async Task PerformActivity()
    {
        await StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

    
        Console.Write("Start listing items in... ");
        await Task.Delay(1000); // Pause for 1 second
        Console.Write("5");
        await Task.Delay(1000); // Pause for 1 second
        Console.Write("\b4");
        await Task.Delay(1000); // Pause for 1 second
        Console.Write("\b3");
        await Task.Delay(1000); // Pause for 1 second
        Console.Write("\b2");
        await Task.Delay(1000); // Pause for 1 second
        Console.Write("\b1");
        await Task.Delay(1000); // Pause for 1 second
        Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b!");
        DateTime endTime = DateTime.Now.AddSeconds(activityDuration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("\nEnter an item: ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");

        await EndActivity();
    }
}
