public class Swimming : Exercise
{
    private double _laps { get; set; }
    public Swimming(DateTime date, double length, double laps, double distance) : base(DateOnly.FromDateTime(date), length, distance)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double Speed()
    {
        double speed = ((Distance() / _length) * 60);
        return speed;
    }

    public override double Pace()
    {
        double pace = _length / Distance();
        return pace;
    }

    
}