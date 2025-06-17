public class Bicycle : Exercise
{
    public Bicycle(DateTime date, double length, double distance) : base(DateOnly.FromDateTime(date), length, distance)
    {

    }

    public override double Distance()
    {

        return (int)_distance;
    }

    public override double Speed()
    {

        return (int)(Distance() / _length) * 60;
    }

    public override double Pace()
    {

        return (int) _length / Distance();
    }

    
}