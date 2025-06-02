public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";

    public string GetTextBookSection()
    {
        return _textbookSection;
    }

    public void SetTextBookSection(string textbook)
    {
        _textbookSection = textbook;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem(string problem)
    {
        _problem = problem;
    }
    
    public string GetHomeworkList()
    {
        return $"{_textbookSection}, {_problem}";
    }
}