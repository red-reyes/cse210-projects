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
        new Comment("Jimin Suk", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."),
        new Comment("Rhea Reyes", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."),
        new Comment("Micky Mo", "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."),
        new Comment("Kubota Shin", "例外的に、問題を提起することはできませんが、責任を負う義務を負うものではありません。")
       };
       //for video 2
       List<Comment> comments2 = new List<Comment>
       {
        new Comment("Delia Villanueva", "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."),
        new Comment("Ropi", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo."),
        new Comment("Rose Chan", "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.")
       };
       //for video 3
       List<Comment> comments3 = new List<Comment>
       {
       new Comment("Sammy Kim", "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. "),
       new Comment("William Choi", "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? 2"),
       new Comment("Warren Kay", "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur")
       };

        //create 3-4 videos with details
        Video video1 = new Video ("Be the Happies Cat", "Lofi Cat", 900, comments1);
        Video video2 = new Video ("Christmas in the Philippines", "Rain Reyes", 8000, comments2);
        Video video3 = new Video ("Minimalist Bedroom", "Amara Chea", 4550, comments3);

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
            Console.WriteLine($"Comments ({video.GetCommentsCount()})");
            //Display comments with each video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"-{comment.GetPerson()} - '{comment.GetTexts()}'");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
       
    }
}