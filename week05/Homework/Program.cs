using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Minnie");
        assignment1.SetTopic("English");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetStudentName("Cassie");
        mathAssignment.SetTopic("Multiplication");
        mathAssignment.SetTextBookSection("Math 101");
        mathAssignment.SetProblem("problem 231");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

    }
}