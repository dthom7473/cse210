public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal Goal '{_goalName}' recorded! You earned {_points} points.");
    }

    public override string DisplayGoal()
    {
        return $"[Eternal Goal] {_goalName}: {_goalDescription} - Points: {_points} per completion";
    }

    public override string Save()
    {
        return $"EternalGoal,{_goalName},{_goalDescription},{_points}";
    }
}