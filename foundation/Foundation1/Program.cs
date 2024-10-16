using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videoList = new List<Video>();
        
        Video video1 = new Video("Highlights", "SportsGuy101", 43);
        Comment comment1video1 = new Comment("Justin Rosier", "What a catch!");
        Comment comment2video1 = new Comment("Annika Gosney", "All you do is watch sports:(");
        Comment comment3video1 = new Comment("Mango", "This video is so long.");

        video1._comments.Add(comment1video1);
        video1._comments.Add(comment2video1);
        video1._comments.Add(comment3video1);

        Video video2 = new Video("I bought a giant bean bag", "David Gosney", 5);
        Comment comment1video2 = new Comment("Kitty Cat", "This is just like my bed but bigger, I love it!");
        Comment comment2video2 = new Comment("Sean Legones", "That looks so soft.");
        Comment comment3video2 = new Comment("Howdy", "Are we allowed to have one as a cowboy?");

        video2._comments.Add(comment1video2);
        video2._comments.Add(comment2video2);
        video2._comments.Add(comment3video2);

        Video video3 = new Video("I'm a cow 2000", "Robots", 13);
        Comment comment1video3 = new Comment("CarpetGuy", "Who knew they would turn cows into robots.");
        Comment comment2video3 = new Comment("Yoda", "Cows are now robots, what a surprise.");
        Comment comment3video3 = new Comment("MilkPro3032", "Not my cows!!!");

        video3._comments.Add(comment1video3);
        video3._comments.Add(comment2video3);
        video3._comments.Add(comment3video3);

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetVideoDetails());
            video.GetComments();
            Console.WriteLine("\n");
        }
    }
}