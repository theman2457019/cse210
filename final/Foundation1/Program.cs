using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("SOLID Principles", "Fred", 10000, new List<Comment>());
        video1.AddComment("Mosh", "Great video!");
        video1.AddComment("John", "Thanks for sharing!");
        video1.AddComment("Mary", "Awesome!");
        video1.AddComment("Jane", "I didn't understand any of that...");

        Video video2 = new Video("Design Patterns", "Mason", 20000, new List<Comment>());
        video2.AddComment("Bill", "Cool Vid!");
        video2.AddComment("Ted", "Not really a fan of this one!");
        video2.AddComment("Rufus", "I didn't appreciate the undertones...");

        Video video3 = new Video("C# Basics", "Corben", 15046, new List<Comment>());
        video3.AddComment("Morgan", "I'm learning so much!");
        video3.AddComment("Jordan", "I'm so confused...");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        
        Console.Clear();
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}