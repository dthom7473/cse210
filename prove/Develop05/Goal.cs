public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected bool _isComplete;

    public string GoalName => _goalName;
    public string GoalDescription => _goalDescription;
    public int Points => _points;
    public bool IsComplete => _isComplete;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _points = points;
        _isComplete = false;
    }

    public virtual void RecordEvent()
    {
        _isComplete = true;
    }

    public virtual string DisplayGoal()
    {
        return $"{_goalName}: {_goalDescription} - Points: {_points} - Completion: {_isComplete}";
    }

    public abstract string Save();
}
