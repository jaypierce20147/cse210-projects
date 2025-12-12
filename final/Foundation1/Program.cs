using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var videos = new List<Video>();

        var v1 = new Video("Epic Fortnite Fun!", "BigJayGaming", 20);
        v1.AddComment(new Comment("Alice", "Nice Video!"));
        v1.AddComment(new Comment("Justin", "Banger!"));
        v1.AddComment(new Comment("Patrick", "He doesn't miss..."));
        videos.Add(v1);

        var v2 = new Video("Wishing Well", "JuiceSandwich", 120);
        v2.AddComment(new Comment("Jaylen", "He was an inspiration :("));
        v2.AddComment(new Comment("Maxwell", "He is pretty good if this is off the top of his head."));
        v2.AddComment(new Comment("Riley", "You can feel what he's saying through the beat!"));
        videos.Add(v2);

        var v3 = new Video("BYU Football Highlights", "BYUFBaller", 300);
        v3.AddComment(new Comment("Addison", "They looked amazing this week!"));
        v3.AddComment(new Comment("Jeffrey", "Priase the Cougs!"));
        v3.AddComment(new Comment("Franklin", "This quarterback sucks"));
        videos.Add(v3);

        var v4 = new Video("R6 GLITCHES IN THE NEW SEASON THAT ARE OP", "Junko", 220);
        v4.AddComment(new Comment("Brandon", "This game keeps getting worse..."));
        v4.AddComment(new Comment("Kyle", "HOW DID HE DO THAT????"));
        v4.AddComment(new Comment("Richard", "If anyone does this on my team, im going to tk them"));
        videos.Add(v4);

        foreach (var vid in videos)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Title : {vid.GetTitle()}");
            Console.WriteLine($"Author: {vid.GetAuthor()}");
            Console.WriteLine($"Length: {vid.GetLength()} seconds");
            Console.WriteLine($"Comments: {vid.GetCommentCount()}");
            Console.WriteLine("Comment list:");

            foreach (var c in vid.GetComments())
            {
                Console.WriteLine("- " + c.ToString());
            }

            Console.WriteLine();
        }
    }
}