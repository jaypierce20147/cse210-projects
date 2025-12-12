using System;

public class Comment
{
    // The getters and setters for the comments under the videos
    private string _commenterName;
    private string _commentText;

    // Stores the commenter and what they said
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Formatting for the string to get printed
    public override string ToString()
    {
        return $"{_commenterName}: {_commentText}";
    }
}