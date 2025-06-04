public class Activity
{
    private string _name;
    private string _description;
    private int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to the activity");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("You have completed the activity");
    }

    public void ShowSpinner(int duration)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\rThinking... {spinnerChars[spinnerIndex]}");
            spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length;
            Thread.Sleep(200); 
        }
        Console.Write("\r");
    }

    public void ShowCount()
    {

    }
}