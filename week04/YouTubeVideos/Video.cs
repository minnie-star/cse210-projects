using System;
using System.Collections.Generic;

public class Video
{
    public string _author;
    public string _title;
    public int _length;
    public List<Comment> _comments;

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = new List<Comment>();
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Author:{_author}\nTitle:{_title}\nLength:{_length}sec");
        Console.WriteLine("Comments: ");
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment.ToString());
        }
    }

    public void StoreComment(string name, string comment)
    {
        _comments.Add(new Comment(name, comment));
    }

    public int GetCommentCount()
    {
        int noOfComments = _comments.Count;
        Console.WriteLine($"Number of comments:{noOfComments}");
        return noOfComments;
    }
}
