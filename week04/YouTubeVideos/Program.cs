using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video.
        Video video1 = new Video(
            "Learning C# for Beginners",
            "Programming Academy",
            600
        );

        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Mary", "I learned a lot."));
        video1.AddComment(new Comment("David", "Please make more videos."));

        // Create the second video.
        Video video2 = new Video(
            "How to Build a Website",
            "Web Development Hub",
            900
        );

        video2.AddComment(new Comment("Sarah", "Very helpful lesson."));
        video2.AddComment(new Comment("Peter", "The explanation was clear."));
        video2.AddComment(new Comment("James", "I enjoyed this video."));
        video2.AddComment(new Comment("Grace", "Thank you for sharing."));

        // Create the third video.
        Video video3 = new Video(
            "Introduction to Programming",
            "Tech World",
            750
        );

        video3.AddComment(new Comment("Daniel", "Excellent presentation."));
        video3.AddComment(new Comment("Faith", "This helped me understand coding."));
        video3.AddComment(new Comment("Michael", "Looking forward to the next lesson."));

        // Create the fourth video.
        Video video4 = new Video(
            "Top 10 Computer Tips",
            "Digital Skills",
            480
        );

        video4.AddComment(new Comment("Samuel", "These tips are amazing."));
        video4.AddComment(new Comment("Esther", "I will definitely try them."));
        video4.AddComment(new Comment("Paul", "Very informative content."));

        // Store all videos in a list.
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display all video information and comments.
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}"
                );
            }

            Console.WriteLine();
        }
    }
}