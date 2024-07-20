using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List <Activity>
        {
            new Running("13 June, 2024", 45, 8),
            new Cycling("14 June 2024", 60, 20),
            new Swimming("15 June 2024", 30, 20)
        };
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetActivitySummary());
        }
    }
}