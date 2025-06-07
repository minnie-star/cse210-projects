public class BreathingActivity : Activity
{
    private int _seconds;
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            DisplayCountDown(5);
            Console.WriteLine("\nBreathe out...");
            DisplayCountDown(5);
        }

        DisplayEndMessage();
    }

    private void DisplayCountDown(int seconds)
    {
        _seconds = seconds;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}