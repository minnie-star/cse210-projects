public class Bicycle : Exercise
{
    private double _speed { get; }
    public Bicycle(DateTime date, double length) : base(DateOnly.FromDateTime(date), length)
    {

    }

    public override int Distance()
    {
        // TODO: Implement logic to calculate distance
        return 0;
    }

    public override int Speed()
    {
        // TODO: Implement logic to calculate speed
        return 0;
    }

    public override int Pace()
    {
        // TODO: Implement logic to calculate pace
        return 0;
    }

    public override string GetSummary()
    {
        // TODO: Implement logic to return a summary string
        return "Running summary";
    }
}