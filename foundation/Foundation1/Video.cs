/*
-have a class for a Video 
    - to track the title, author, and length (in seconds) of the video. 
    - Each video also has responsibility to store a list of comments
    - have a method to return the number of comments
    
*/
using System;
using System.Collections.Generic;

class Video
{
    //identify the fields to store information 
    private string _title;
    private string _author;
    private int _length; //in seconds
    //list of comments
    private List<Comment>_comments;

    //constructors to initialize Video
    public Video (string title, string author, int length, List<Comment>comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments; //initialize comment
    }

    //get the title
    public string GetTitle()
    {
        return _title;
    }
    //get the author
    public string GetAuthor()
    {
        return _author;
    }
    //get int length
    public int GetLength()
    {
        return _length;
    }
   
    //count the comments

    public int GetCommentsCount()
    {
        return _comments.Count;
    }

     /*
    - Each video also has responsibility to store a list of comments
    - have a method to return the number of comments
    */
    public List<Comment> GetComments()
    {
        return _comments;
    } 
}