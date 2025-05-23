public class Scripture
{
    public List<string> _reference = new List<string>
    {
        "Psalm 27:1",
        "Proverbs 13:3",
        "Matthew 18:4",
        "Romans 8:16",
        "Romans 10:10",
        "Philippians 4:4"
    };

    public List<string> _text = new List<string>
    {
        "The Lord is my light and my salvation whom shall I fear? the Lord is the strength of my life of whom shall I be afraid?",
        "He that keepeth his mouth keepeth his life: but he that openeth wide his lips shall have destruction.",
        "Whosoever therefore shall humble himself as this little child the same is greatest in the kingdom of heaven.",
        "The spirit itself beareth witness with our spirit, that we are the children of God.",
        "For with the heart man believeth unto righteousness; and with the mouth confession is made unto salvation.",
        "Rejoice in the Lord always: and again I say Rejoice."
    };

    private List<List<Word>> _wordLists;
    private int _score = 0;
    
    public Scripture()
    {
        _wordLists = new List<List<Word>>();

        foreach (string scriptureText in _text)
        {
            var wordObjects = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
            _wordLists.Add(wordObjects);
        }
    }

    public void HideRandomWords(int index)
    {
        Random random = new Random();
        var candidates = new List<int>();
       
        for (int j = 0; j < _wordLists[index].Count; j++)
        {

            if (!_wordLists[index][j].ToString().Contains("_"))
            {
                candidates.Add(j);
            }
        }

        if (candidates.Count == 0) return;

        int wordsToHide = Math.Min(2, candidates.Count);
        for (int k = 0; k < wordsToHide; k++)
        {
            int selectedIndex = candidates[random.Next(candidates.Count)];
            _wordLists[index][selectedIndex] = new Word(new string('_', _wordLists[index][selectedIndex].ToString().Length));
        }
    }

    public bool AllWordsHidden(int index)
    {
        foreach (Word word in _wordLists[index])
        {
            if (!word.ToString().Contains("_"))
                return false;
        }
        return true;
    }

    public void Display(int index)
    {
        Console.WriteLine($"{_reference[index]}\n{string.Join(" ", _wordLists[index])}");
    }
    
    public void MemorizationCycle()
    {
        for (int i = 0; i < _wordLists.Count; i++)
        {
            Console.Clear();
            Display(i);

            while (!AllWordsHidden(i))
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit") return;

                HideRandomWords(i);
                Console.Clear();
                Display(i);
                Console.WriteLine($"{i + 1}/{_wordLists.Count}");
            }
            _score += 10;
            Console.WriteLine($"\nAll words hidden! Your Score: {_score}");
            Console.WriteLine("Press Enter to proceed to the next scripture.");
            Console.ReadLine();
            Console.WriteLine($"Progress: {i + 1}/{_wordLists.Count} scriptures memorized.");
        }
        Console.WriteLine($"\nAll scriptures have been memorized! Final Score:{_score} Program ending.");
    }

}