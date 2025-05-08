using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string UserName = PromptUserName();
        int number = PromptFavouriteNumber();

        int square = SquareNumber(number);

        DisplayResult(UserName, square); 
    }
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptFavouriteNumber()
        {
            Console.Write($"Please enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
             int square = number * number;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
        Console.WriteLine($"{name} the square of your number is {square}");
        }
}