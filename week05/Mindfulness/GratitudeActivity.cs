public class GratitudeActivity : Activity
{


    public GratitudeActivity() : base("Gratitude Activity", "This activity you will help you list things your grateful for. This helps shift focus to positive aspects of life.", 0) 
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("\nTake a moment to reflect on things you're grateful for.");
        ShowSpinner(3);

        List<string> gratitudeResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("\nStart listing things you're grateful for:");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (response?.Length > 0)
                    gratitudeResponses.Add(response);
            }
        }

        ShowSpinner(3);
        Console.WriteLine("\nYou listed the following things you're grateful for:");
        foreach (var item in gratitudeResponses)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine("\nTake a moment to appreciate your responses!");
        ShowSpinner(3);
        DisplayEndMessage();
    }
}