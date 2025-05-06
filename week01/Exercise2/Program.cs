using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter you grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you failed, better luck next time.");
        }
    }
}