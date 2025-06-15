using System.ComponentModel;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class GoalManager
{
    private string _name;
    private int _score;
    private List<Goal> _goals;
    private const string FileName = "goals.txt";


    public GoalManager(string name)
    {
        _name = name;
        _score = LoadScore();
        _goals = new List<Goal>();
    }


    public void AddGoal(Goal goal)
    {
        using (StreamWriter writer = new StreamWriter(FileName, true))
        {
            writer.WriteLine(goal.ToString());
        }
        Console.WriteLine("Goal saved!");
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();
        Console.Write("Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }

    }
    
    public void ListGoalsToFile(string FileName)
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine($"\n👤 {_name} | Score: {_score}");
            if (_goals != null)
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.ToString());
                }
            }
        }
        Console.WriteLine("Goals listed in file successfully!");
    }

    public void RecordGoal(List<Goal> _goals, Player player)
    {
        ShowGoals(_goals);
        Console.Write("Enter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent(player);
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void ShowGoals(List<Goal> _goals)
    {
        Console.WriteLine("\n>>> Goals <<<");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i]._name} ({_goals[i]._description})");
        }
    }

    public void SaveScore()
    {
        using (StreamWriter writer = new StreamWriter("score.txt"))
        {
            writer.WriteLine(_score);
        }
    }

    public int LoadScore()
    {
        if (File.Exists("score.txt"))
        {
            using StreamReader reader = new StreamReader("score.txt");
            {
                return int.Parse(reader.ReadLine());
            }
        }
        return 0;
    }

    public void ShowScore(int _totalPoints)
    {
        Console.WriteLine($"\n👤 {_name} | Score: {_totalPoints}");
    }

    public void SaveGoals(string FileName, List<Goal> goals, Player player)
    {
        using (StreamWriter write = new StreamWriter(FileName))
        {
            write.WriteLine(player._totalPoints);
            foreach (Goal goal in _goals)
            {
                write.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    
    public void LoadGoals(string FileName, List<Goal> _goals, Player player)
    {

        if (File.Exists(FileName))
        {
            string[] lines = File.ReadAllLines(FileName);
            player.AddPoints(int.Parse(lines[0])); // Load points

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (bool.Parse(parts[4])) sg.RecordEvent(player);
                        _goals.Add(sg);
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                        for (int j = 0; j < int.Parse(parts[4]); j++)
                            cg.RecordEvent(player);
                        _goals.Add(cg);
                        break;

                }
            }
            Console.WriteLine("Goals loaded.");

        }
    }
}

    
