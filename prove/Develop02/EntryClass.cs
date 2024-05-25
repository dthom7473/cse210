using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string UserEntry { get; set; }

    public Entry(string prompt, string userEntry)
    {
        Date = DateTime.Now.ToString("MM/dd/yyyy");
        Prompt = prompt;
        UserEntry = userEntry;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {Prompt}");
        Console.WriteLine(UserEntry);
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"Date: {Date} - Prompt: {Prompt}\n{UserEntry}\n";
    }
}
