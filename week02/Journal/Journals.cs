//https://www.webdevtutor.net/blog/c-sharp-save-file
//https://www.csharp-examples.net/read-text-file/
class Journal
{
    private List<Entries> _entries = new List<Entries>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I extend a helping hand to someone today?"
    };

    public void WriteEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        _entries.Add(new Entries(prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var Entries in _entries)
        {
            Console.WriteLine(Entries);
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadJournal(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            foreach (var line in File.ReadLines(filename))
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
