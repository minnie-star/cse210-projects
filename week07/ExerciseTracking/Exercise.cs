public abstract class Exercise
{
    protected  double _length { get; set; }
    protected DateOnly _date { get; set; }
    protected double _distance { get; set; }

    public Exercise(DateOnly date, double length, double distance)
    {
        _length = length;
        _date = date;
        _distance = distance;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min) - " +
                $"Distance: {Distance():0.0} km - Speed: {Speed():0.0} kph - " +
                $"Pace: {Pace():0.0} min per km";
    }
}