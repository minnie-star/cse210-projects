public class Comment
{
    private string _name;
    private string _comment; 

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public void SetComment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public override string ToString()
    {
        return $"{_name}: {_comment} ";
    }
}