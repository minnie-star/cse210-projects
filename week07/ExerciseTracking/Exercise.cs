public abstract class Exercise
{
    protected  double _length { get; }
    protected DateOnly _date { get; }

    public Exercise(DateOnly date, double length)
    {
        _length = length;
        _date = date;
    }

    public abstract int Distance();
    public abstract int Speed();
    public abstract int Pace();
    public abstract string GetSummary();
}