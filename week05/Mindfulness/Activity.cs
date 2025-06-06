public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
       
    }
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name}\n{_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin.");
        ShowSpinner(3);

    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.Clear();
        Console.WriteLine($"You have completed {_name} in {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    
}