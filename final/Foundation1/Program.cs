using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create list to hold videos
        var videos = new List<Video>();

        // Video 1
        var v1 = new Video("Epic Fortnite Fun!", "BigJayGaming", 20);
        v1.AddComment(new Comment("Alice", "Nice Video!"));
        v1.AddComment(new Comment("Justin", "Banger!"));
        v1.AddComment(new Comment("Patrick", "He doesn't miss..."));
        videos.Add(v1);

        // Video 2
        var v2 = new Video("Wishing Well", "JuiceSandwich", 120);
        v2.AddComment(new Comment("Jaylen", "He was an inspiration :("));
        v2.AddComment(new Comment("Maxwell", "He is pretty good if this is off the top of his head."));
        v2.AddComment(new Comment("Riley", "You can feel what he's saying through the beat!"));
        videos.Add(v2);

        // Video 3
        var v3 = new Video("BYU Football Highlights", "BYUFBaller", 300);
        v3.AddComment(new Comment("Addison", "They looked amazing this week!"));
        v3.AddComment(new Comment("Jeffrey", "Priase the Cougs!"));
        v3.AddComment(new Comment("Franklin", "This quarterback sucks"));
        videos.Add(v3);

        // Video 4
        var v4 = new Video("R6 GLITCHES IN THE NEW SEASON THAT ARE OP", "Junko", 220);
        v4.AddComment(new Comment("Brandon", "This game keeps getting worse..."));
        v4.AddComment(new Comment("Kyle", "HOW DID HE DO THAT????"));
        v4.AddComment(new Comment("Richard", "If anyone does this on my team, im going to tk them"));
        videos.Add(v4);
        
        // Display of the comments
        foreach (var vid in videos)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Title : {vid.Title}");
            Console.WriteLine($"Author: {vid.Author}");
            Console.WriteLine($"Length: {vid.Length} seconds");
            Console.WriteLine($"Comments: {vid.GetCommentCount()}");
            Console.WriteLine("Comment list:");
            
            // Iterate through the comments
            foreach (var c in vid.Comments)
            {
                Console.WriteLine("-" + c.ToString());
            }
            Console.WriteLine();
        }
    }
}