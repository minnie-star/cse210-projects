public class ListingActivity : Activity
{
    
    private List<string> _prompt = new List<string>()
    {
        "Who are the people that you appreciate?",
        "What are personal strenghts of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this week?",
        "Who are some of your personal heros?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you list and reflect on on your life and keep a list of those things.",0)
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("\n" + _prompt[new Random().Next(_prompt.Count)]);
        ShowSpinner(3);

        List<string> promptResponses = new List<string>(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 
        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (response.Length > 0)
                {
                    promptResponses.Add(response);
                }
            }
        }
        ShowSpinner(3);
        Console.WriteLine($"\nYou listed {promptResponses.Count} items.");
        DisplayEndMessage();
    }
        
    

    
}