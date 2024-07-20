public abstract class Activity
{
    private string _activityDate;
    private int _activityDurration;

    public Activity(string activityDate, int activityDurration)
    {
        _activityDate = activityDate;
        _activityDurration = activityDurration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetActivitySummary()
    {
        return $"{_activityDate}: {GetType().Name}\nDuration: {_activityDurration} minutes - Distance: {GetDistance():0.0} km - Speed: {GetSpeed():0.0} km / hour - Pace: {GetPace():0.0} min per km.\n";
    }
    
    public int ActivityDurration
    {
        get {return _activityDurration;}
    }
}