using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        

        Video video1 = new Video("Ash", "GRWM", 300);
        Video video2 = new Video("Liz", "OOTD", 360);
        Video video3 = new Video("Mike", "POV", 270);

        video1.StoreComment("John", "I love this product");
        video1.StoreComment("Mary", "I wish I knew it sooner");
        video1.StoreComment("Sam", "It's totally amazing");
        

        video2.StoreComment("John", "I love this product");
        video2.StoreComment("Peter", "I recieved mine in 2 days");
        video2.StoreComment("Josh", "I can't wait to try it");
        

        video3.StoreComment("Max", "I heard about it");
        video3.StoreComment("Wendy", "I will try it");
        video3.StoreComment("Andy", "I love this product");
        

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayAll();
            video.GetCommentCount();
        }

    }
}