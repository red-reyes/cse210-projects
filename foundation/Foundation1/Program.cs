/*
Write a program that
    - for each one, add a list of 3-4 comments (with the commenter's name and text)
    - creates 3-4 videos, 
    - sets the appropriate values, 
    - and 
    - Put each of these videos in a list

    - iterate through the list of videos
    - for each one, display the title, author, length, number of comments (from the method) 
    - then list out all of the comments for that video. Repeat this display for each video in the list.
*/

using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
      
       //each one, add a list of 3-4 comments (with the *commenter's name and *text)
       //these comments will be added in the list of comments

       //for video 1
       List<Comment> comments1 = new List<Comment>
       {
        new Comment("Person1", "Comment1"),
        new Comment("Person2", "Comment2"),
        new Comment("Person3", "Comment3"),
        new Comment("Person4", "Comment4")
       };
       //for video 2
       List<Comment> comments2 = new List<Comment>
       {
        new Comment("Person4", "Comment3"),
        new Comment("Person5", "Comment4"),
        new Comment("Person3", "Comment5")
       };
       //for video 3
       List<Comment> comments3 = new List<Comment>
       {
       new Comment("Person1", "Comment1"),
       new Comment("Person2", "Comment2"),
       new Comment("Person3", "Comment3")
       };

        //create 3-4 videos with details
        Video video1 = new Video ("Title A", "Author A", 900, comments1);
        Video video2 = new Video ("Title B", "Author B", 8000, comments2);
        Video video3 = new Video ("Title C", "Author C", 4550, comments3);

        //   - Put each of these videos in a list.
        List<Video> Videos = new List<Video> { video1, video2, video3};

        //display details of the videos
        //for each one, display the title, author, length, number of comments (from the method) 
        //applying foreach loop to iterate on each video
        foreach (Video video in Videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length in Seconds: {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentsCount()}");
            Console.WriteLine($"Comments: ");
            //Display comments with each video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"-{comment.GetPerson()}:{comment.GetTexts()}");
            }
            Console.WriteLine("-------------------------------------------");
        }
       
    }
}