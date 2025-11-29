using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("C# Classes Explained", "Code Academy", 600);
        video1.AddComment(new Comment("Robert", "This video really helped explain things for me!"));
        video1.AddComment(new Comment("Wes", "I loved the video format!"));
        video1.AddComment(new Comment("Alex", "When is your next video coming out?"));
        
        Video video2 = new Video("Intro to C#", "Trifold", 900);
        video2.AddComment(new Comment("Jordan", "Grea video!"));
        video2.AddComment(new Comment("Beth", "Can you do a vido on the other C languages?"));
        video2.AddComment(new Comment("Johhny", "This seems like a lot..."));

        Video video3 = new Video("Coding for Amatures", "Dev Channel", 640);
        video3.AddComment(new Comment("James", "Nice overview of everything!"));
        video3.AddComment(new Comment("Chelsea", "I really love the way you dumbed everything down."));
        video3.AddComment(new Comment("Pat", "Subbed, can't wait for more of your content!"));

        Video video4 = new Video("Coding - A Guide to the Fundamentals", "CS Foundations", 500);
        video4.AddComment(new Comment("Jarred", "Great video, solid foundation!"));
        video4.AddComment(new Comment("Taylor", "This makes a lot more sense now, thanks!"));
        video4.AddComment(new Comment("Morgan", "Great example!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        Console.Clear();

        int i = 1;
        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"Video #{i}");
            Console.WriteLine("---------------------------------------------------------------------------");
            video.DisplayVideoInfo();
            i++;
        }
    }
}