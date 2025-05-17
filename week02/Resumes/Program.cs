using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startDate = "2022";
        job1._endDate = "2024";
        job1.DisplayJobDetails();
        

        Job job2 = new Job();
        job2._jobTitle = "Senior Engineer";
        job2._company = "Amazone";
        job2._startDate = "2024";
        job2._endDate = "2025";
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Minnie Star";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
    } 
}

