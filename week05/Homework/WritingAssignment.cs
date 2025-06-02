public class WritingAssignment : Assignment
{
    private string _title = "";

    public void GetTitle(string title)
    {
         _title = title;
    }

    public string SetTiltle()
    {
        return _title;
    }
    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}