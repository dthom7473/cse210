public class Swimming : Activity
{
    private int _swimmingLaps;
    private const double _lapDistanceKm = 50.0 / 1000.0; //50 meters per lab

    public Swimming(string activityDate, int activityDurration, int swimmingLaps)
        :base(activityDate, activityDurration)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double GetDistance()
    {
        return _swimmingLaps * _lapDistanceKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / ActivityDurration) * 60;
    }

    public override double GetPace()
    {
        return (ActivityDurration / GetDistance());
    }
}