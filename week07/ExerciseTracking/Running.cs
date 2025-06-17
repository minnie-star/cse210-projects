public class Runnuning : Exercise
{
    
    public Runnuning(DateTime date, double length, double distance) : base(DateOnly.FromDateTime(date), length, distance)
    {
       
    }

    public override double Distance()
    {
        return (int)_distance;
    }

    public override double Speed()
    {
        double speed = (_distance * _length) * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _length / Distance();
        return pace;
    }

    
}