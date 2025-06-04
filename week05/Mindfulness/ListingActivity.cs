public class ListingActivity : Activity
{
    private int _count;
    private List<string> _promptResponse = new List<string>();
    private List<string> _prompt = new List<string>()
    {
        "Who are the people that you appreciate?",
        "Whate are the personal strenghts of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this week?",
        "Who are some of your personal heros?"
    };

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _count = count;
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompt[random.Next(_prompt.Count)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        _promptResponse.Add(new(prompt));

    }

    public void NumberOfItem()
    {
        foreach (string item in _promptResponse)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Total responses: {_promptResponse.Count}");
    } 
}