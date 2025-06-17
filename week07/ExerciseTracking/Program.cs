using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Runnuning runnuning = new Runnuning(DateTime.Now, 5.0, 3.0);
        
        Swimming swimming = new Swimming(DateTime.Now, 2.0, 4.0, 1.0);
        
        Bicycle bicycle = new Bicycle(DateTime.Now, 7.0, 7.0);
        

        List<Exercise> exercises = new List<Exercise>() { runnuning, swimming, bicycle };
        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}