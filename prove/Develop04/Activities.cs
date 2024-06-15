
using System.Runtime;

public class Activities
{
    protected string activityName;
    protected string activityDescription;
    protected int activityDuration;

    public Activities(int activityDuration, string activityName, string activityDescription)
    {
        this.activityDuration = activityDuration;
        this.activityName = activityName;
        this.activityDescription = activityDescription;
    }

    // Method to set the duration of the activity
    protected void SetDuration()
    {
        Console.Write("How long would you like to do the activity (seconds)?: ");
        while (!int.TryParse(Console.ReadLine(), out activityDuration) || activityDuration <= 14)
        {
            Console.WriteLine("For the best results, please enter a number greater than 15.");
        }
    }

    public async Task StartActivity()
    {
        SetDuration();

        Console.WriteLine($"Beginning {activityName}. Duration: {activityDuration} seconds...");
        Console.WriteLine(activityDescription);
        Console.WriteLine("Get ready to begin...");
        int amount = 5;
        while (amount > 0)
        {
        Console.Write("\b\b\b\b\b\b\b\b[=     ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[==    ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[===   ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[ ==== ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[  ====]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[   ===]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[    ==]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[     =]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[      ]");
        await Task.Delay(100);
        amount--;
        }
        Console.Write("\n");
    }

    public async Task EndActivity()
    {
        Console.WriteLine($"Good Job completing the {activityName}!\nReturning to the main menu...");
        int amount = 5;
        while (amount > 0)
        {
        Console.Write("\b\b\b\b\b\b\b\b[=     ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[==    ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[===   ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[ ==== ]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[  ====]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[   ===]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[    ==]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[     =]");
        await Task.Delay(100);
        Console.Write("\b\b\b\b\b\b\b\b       ");

        Console.Write("\b\b\b\b\b\b\b\b[      ]");
        await Task.Delay(100);
        amount--;
        }
        Console.Write("\n");
    }
}
