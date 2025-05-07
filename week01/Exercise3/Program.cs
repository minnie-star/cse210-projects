using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        int numberToGuess = random.Next(1, 100); 
        int userGuess = 0;

        Console.WriteLine("Guess a number between 1 and 100:");

        while (userGuess != numberToGuess)
        {
            Console.Write("What is your guess: ");
            
            
            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low, try again!");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high, try again!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine($"Correct! The number was {numberToGuess}.");
    
        
        }
    }




        