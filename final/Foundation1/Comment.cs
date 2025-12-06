using System;

public class Comment
{
    // The getters and setters for the comments under the videos
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Stores the commenter and what they said
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    // Formatting for the string to get printed
    public override string ToString()
    {
        return $"{CommenterName}: {CommentText}";
    }
}