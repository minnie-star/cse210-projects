using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.DisplayStartMessage();
        reflectingActivity.GetRandomPrompt();
        reflectingActivity.GetRandonQuestion();
        reflectingActivity.Run();
        //reflectingActivity.DisplayPropmt();
        //reflectingActivity.DisplayQuestion();
    }
}