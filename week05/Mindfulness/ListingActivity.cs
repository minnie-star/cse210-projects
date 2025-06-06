public class ListingActivity : Activity
{
    private int _count;
    
    private List<string> _prompt = new List<string>()
    {
        "Who are the people that you appreciate?",
        "Whate are the personal strenghts of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this week?",
        "Who are some of your personal heros?"
    };

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\n" + _prompt[new Random().Next(_prompt.Count)]);
        ShowSpinner(3);

        List<string> _promptResponse = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response)) _promptResponse.Add(response);
        }

        Console.WriteLine($"\nYou listed {_promptResponse.Count} items");
    }

    
}