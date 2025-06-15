public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(Player player)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            player.AddPoints(_points);
            Console.WriteLine($"Goal '{_name}' completed! +{_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => _isComplete ? "[X]" : "[ ]";

    public override string GetStringRepresentation()
        => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";

    public override int RecordProgress()
    {
       
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

        
}