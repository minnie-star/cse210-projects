public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(Player player)
    {
        player.AddPoints(_points);
        Console.WriteLine($"Eternal Goal '{_name}' recorded! +{_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞]";

    public override string GetStringRepresentation()
        => $"EternalGoal|{_name}|{_description}|{_points}";

    public override int RecordProgress() => _points;

}