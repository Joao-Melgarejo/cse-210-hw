using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();

        Video video1 = new Video("Top 10 Soccer Goals of 2024", "Sports Fanatics", 350);
        video1.AddComment(new Comment("Mark", "Incredible compilation! That bicycle kick was insane."));
        video1.AddComment(new Comment("Sarah", "Missing a few from the Premier League, but still great."));
        video1.AddComment(new Comment("Leo", "Goal number 7 is pure genius."));
        videos.Add(video1);

        Video video2 = new Video("Top 5 Programming Languages", "Ana García", 220);
        video2.AddComment(new Comment("David", "Interesting list, although Python is missing."));
        video2.AddComment(new Comment("Eva", "I would add languages like Go or Rust."));
        video2.AddComment(new Comment("Frank", "Good video, very complete."));
        videos.Add(video2);

        Video video3 = new Video("The Tactical Brilliance of the 4-3-3", "The Analyst", 480);
        video3.AddComment(new Comment("Daniel", "Excellent breakdown of the mid-field triangle."));
        video3.AddComment(new Comment("Olivia", "I think the 4-2-3-1 is more effective against possession teams."));
        video3.AddComment(new Comment("Ryan", "This really helped me understand my team's strategy."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}   