public class ReflectingActivity : Activity
{
    private List<string> _prompt = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was completed?",
        "What made this time different than the other time when you were not as successful?",
        "What was your favourite thing about this experience?",
        "What could you learn from this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
       
    }

    public void Run()
    {
        Random random = new Random();
        List<string> shuffledQuestions = _questions.OrderBy(q => random.Next()).ToList();
        foreach (var question in shuffledQuestions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
            System.Threading.Thread.Sleep(1000);
        }
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompt[random.Next(_prompt.Count)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        Console.ReadLine();

    }

    public void GetRandonQuestion()
    {
        foreach (string question in _questions)
        {
            Random random = new Random();
            string randomQuestion = _questions[random.Next(_questions.Count)];
            Console.WriteLine(randomQuestion);
            Console.Write("Your response: ");
            Console.ReadLine();
        }
        
    }

    public void DisplayPropmt()
    {
        foreach (var prompt in _prompt)
        {
            Console.WriteLine(prompt);
        }
    }

    public void DisplayQuestion()
    {
        foreach (var questions in _questions)
        {
            Console.WriteLine(questions);
        }
    }

}