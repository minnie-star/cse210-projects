using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        GoalManager goalManager = new GoalManager(userName);
        List<Goal> goals = new List<Goal>();
        string FileName = "goals.txt"; 
        Player player = new Player(userName);


        while (true)
        {
            Console.WriteLine("1. Create Goal\n2. Save Goal\n3. Load Score\n4. Show Goal\n5. Record Event\n6. Show Score\n7. Quit");
            
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.SaveGoals(FileName, goals, player);
                    break;
                case "3":
                    goalManager.LoadGoals(FileName, goals, player);
                    break;
                case "4":
                    goalManager.ShowGoals(goals);
                    break;
                case "5":
                    goalManager.RecordGoal(goals, player);
                    break;
                    case "6":
                    goalManager.ShowScore(player._totalPoints);
                    break;
                    case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

    }
}
 
       



