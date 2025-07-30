using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("What are you grateful today?", "Richard Johnson", 480);
        video1.AddComment(new Video.Comment("I'm grateful for a new day full of new opportunities", "Olivia Jones"));
        video1.AddComment(new Video.Comment("For a new job", "Laura Anderson"));
        video1.AddComment(new Video.Comment("For the Gospel, for my Savior, and for my family", "Hazel Davis"));
        videos.Add(video1);

        Video video2 = new Video("Share one of your favorite scripture", "Ruth Miranda", 300);
        video2.AddComment(new Video.Comment("Philippina 4:13 'I can do all things throught Christ which strengtheneth me'", "Camila Garcia"));
        video2.AddComment(new Video.Comment("Proverbs 1:7 'The fear of the Lord is the beginning of knowledge'", "Aurora Wilson"));
        video2.AddComment(new Video.Comment("Matthew 11:28 'Come unto me, all ye that labour and are heavy laden, and I will give you rest'", "Liam Jackson"));
        videos.Add(video2);


        Video video3 = new Video("What is your favorite fruit?", "Sophia Smith", 240);
        video3.AddComment(new Video.Comment("Mango", "Aria Brown"));
        video3.AddComment(new Video.Comment("Watermelon", "William Martinez"));
        video3.AddComment(new Video.Comment("Strawberries", "Mia Lopez"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Video: {video._Title} by {video._Author}");
            Console.WriteLine($"Length: {video._Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}\n");

            foreach (var Comment in video.CommentList)
            {
                Console.WriteLine($"Comment by {Comment._Name}; {Comment._Text}\n ");
            }
            Console.WriteLine("======================\n");
        }
    }
}
class Video
{
    public string _Title;
    public string _Author;
    public int _Length;
    public List<Comment> CommentList;

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
         CommentList = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        CommentList.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return CommentList.Count;
    }

    public class Comment
    {
        public string _Text;
        public string _Name;
        public Comment(string text, string name)
        {
            _Name = name;
            _Text = text;
        }

        }
}
    