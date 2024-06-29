public class GoalChecklist : Goal
{
    private int _requiredCount;
    private int _currentCount;
    private int _bonusPoints;

    public int RequiredCount => _requiredCount;
    public int CurrentCount
    {
        get => _currentCount;
        set => _currentCount = value;
    }
    public int BonusPoints => _bonusPoints;

    public GoalChecklist(string name, string description, int points, int requiredCount, int bonusPoints) 
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _requiredCount)
        {
            _isComplete = true;
        }
    }

    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()} - Progress: {_currentCount}/{_requiredCount}";
    }

    public override string Save()
    {
        return $"GoalChecklist,{_goalName},{_goalDescription},{_points},{_requiredCount},{_currentCount},{_bonusPoints}";
    }
}