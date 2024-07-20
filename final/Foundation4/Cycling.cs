public class Cycling : Activity
{
    private double _speed;

    public Cycling(string activityDate, int activityDurration, double speed)
        :base(activityDate, activityDurration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * ActivityDurration) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}