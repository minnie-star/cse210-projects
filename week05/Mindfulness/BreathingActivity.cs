using System.Runtime.InteropServices;

public class BreatingActivity : Activity
{
    public BreatingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        for (int i = 0; i < _duration / 2; i++)
        {
            Console.WriteLine("\nBreathe in...");
            DisplayCountDown(3);
            Console.WriteLine("\vBreathe out...");
            DisplayCountDown(3);
        }
        DisplayEndMessage();
    }

    private void DisplayCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    
    
}