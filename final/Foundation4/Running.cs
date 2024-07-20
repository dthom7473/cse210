public class Running : Activity
{
    private double _distance;

    public Running(string activityDate, int activityDurration, int distance)
        :base (activityDate, activityDurration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / ActivityDurration) * 60;
    }

    public override double GetPace()
    {
        return ActivityDurration / _distance;
    }
}