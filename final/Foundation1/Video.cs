using System;

public class Video
{
    // Get and set the title, author, length and create a list of comments
    public string Title { get; set;}
    public string Author { get; set;}
    public int Length { get; set;}
    private List<Comment> _comments = new List<Comment>();

    // Store what the title author and length of video is
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
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
    public IReadOnlyList<Comment> Comments => _comments.AsReadOnly();
}