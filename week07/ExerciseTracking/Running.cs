public class Runnuning : Exercise
{
    protected double _distance { get; }
    public Runnuning(DateTime date, double length, double distance) : base(DateOnly.FromDateTime(date), length)
    {
        _distance = distance;
    }

    public override int Distance()
    {
        return (int)_distance;
    }

    public override int Speed()
    {
        return (int)(_distance * _length) * 60; 
    }

    public override int Pace()
    {
        return (int) _length / Distance();
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length}min) - Distance: {_distance}km - Speed: {Speed}kph - Pace: {Pace}min per km";
    }
}