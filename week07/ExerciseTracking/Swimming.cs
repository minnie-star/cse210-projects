public class Swimming : Exercise
{
    private double _laps { get; }
    public Swimming(DateTime date, double length, double laps) : base(DateOnly.FromDateTime(date), length)
    {
        _laps = laps;
    }

    public override int Distance()
    {
        return (int)_laps * 50 / 1000;
    }

    public override int Speed()
    {
        return (int)((Distance() / _length) * 60);
    }

    public override int Pace()
    {
        return (int) _length / Distance();
    }

    public override string GetSummary()
    {
       
        return $"{_date} Running ({_length}min) - Distance: {Distance}km - Speed: {Speed}kph - Pace: {Pace}min per km";
    }
}