using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> allVideos = new List<Video>();
        
        Console.WriteLine("Welcome to Video Comment Tracker\n\n");

        // Video #1
        Video video1 = new Video();
        video1.setTitle("The Color Purple");
        video1.setAuthor("Alice Walker");
        video1.setLength(240);        

        Comment video1Comment1 = new Comment("Joseph Pauli", "This was the best YouTube Video Ever!");
        video1.addToCommentList(video1Comment1);

        Comment video1Comment2 = new Comment("Miranda Martin", "I LOL'd out of my chair.");
        video1.addToCommentList(video1Comment2);

        Comment video1Comment3 = new Comment("Iona Perkins", "You need to make a Part 2!");
        video1.addToCommentList(video1Comment3);

        allVideos.Add(video1);

        // Video #2
        Video video2 = new Video();
        video2.setTitle("Cats Galore");
        video2.setAuthor("Samantha Jane");
        video2.setLength(520);
        
        Comment video2Comment1 = new Comment("Jane Smith", "Not my favorite");
        video2.addToCommentList(video2Comment1);

        Comment video2Comment2 = new Comment("Emily Rogers", "I don't want to be rude but Eeeeewwww.");
        video2.addToCommentList(video2Comment2);

        Comment video2Comment3 = new Comment("Phillip Johnson", "Just what the world needed. More cats.");
        video2.addToCommentList(video2Comment3);

        allVideos.Add(video2);


        // Video #3
        Video video3 = new Video();
        video3.setTitle("Funniest Baby Videos");
        video3.setAuthor("Paul Simon");
        video3.setLength(645);

        Comment video3Comment1 = new Comment("Peter Patrone", "Hilarious!");
        video3.addToCommentList(video3Comment1);

        Comment video3Comment2 = new Comment("Josephine Lopez", "Super cute");
        video3.addToCommentList(video3Comment2);

        Comment video3Comment3 = new Comment("Mark Donello", "I'd love to see more.");
        video3.addToCommentList(video3Comment3);

        allVideos.Add(video3);

        // Video #4
        Video video4 = new Video();
        video4.setTitle("People Who Trip");
        video4.setAuthor("Gabriel Torrez");
        video4.setLength(874);

        Comment video4Comment1 = new Comment("Douglas Martin", "Hard to watch them fall down.");
        video4.addToCommentList(video4Comment1);

        Comment video4Comment2 = new Comment("Paul Simon", "Oh man!");
        video4.addToCommentList(video4Comment2);

        Comment video4Comment3 = new Comment("Brandon Shwartz", "So funny");
        video4.addToCommentList(video4Comment3);

        allVideos.Add(video4);

        foreach (Video video in allVideos)
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine($"\n{video.getTitle()} \n{video.getAuthor()} \n{video.getLength()} seconds \n{video.getNumComments()} comments: \n");
            foreach (Comment comment in video.getCommentList())
            {
                Console.WriteLine($"{comment.getPersonName()}: {comment.getComment()}");
            }
        }

    }
}