using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("What are you grateful today?", "Richard Johnson", 480);
        video1.AddComment(new Comment("I'm grateful for a new day full of new opportunities", "Olivia Jones"));
        video1.AddComment(new Comment("For a new job", "Laura Anderson"));
        video1.AddComment(new Comment("For the Gospel, for my Savior, and for my family", "Hazel Davis"));
        videos.Add(video1);

        Video video2 = new Video("Share one of your favorite scripture", "Ruth Miranda", 300);
        video2.AddComment(new Comment("Philippina 4:13 'I can do all things throught Christ which strengtheneth me'", "Camila Garcia"));
        video2.AddComment(new Comment("Proverbs 1:7 'The fear of the Lord is the beginning of knowledge'", "Aurora Wilson"));
        video2.AddComment(new Comment("Matthew 11:28 'Come unto me, all ye that labour and are heavy laden, and I will give you rest'", "Liam Jackson"));
        videos.Add(video2);


        Video video3 = new Video("What is your favorite fruit?", "Sophia Smith", 240);
        video3.AddComment(new Comment("Mango", "Aria Brown"));
        video3.AddComment(new Comment("Watermelon", "William Martinez"));
        video3.AddComment(new Comment("Strawberries", "Mia Lopez"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Video: {video.Title} by {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}\n");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.Name}; {comment.Text}\n ");
            }
            Console.WriteLine("======================\n");
        }
    }
}


    