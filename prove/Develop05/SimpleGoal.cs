public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        // Specific implementation for SimpleGoal if needed
    }

    public override string Save()
    {
        return $"SimpleGoal,{_goalName},{_goalDescription},{_points},{_isComplete}";
    }
}