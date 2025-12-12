using System;

public class Video
{
    // Get and set the title, author, length and create a list of comments
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // Store what the title author and length of video is
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    // Allows the program to add comments
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Counts the comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Allows the code to see it, but not modify it.
    public List<Comment> GetComments()
    {
        return _comments;
    }
}