/*
- A comment should be defined by the Comment class
        - has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
*/

using System;
using System.Collections.Generic;

class Comment
{
    //fields for details in this class
    private string _person;
    private string _texts;

    //constructors
    public Comment(string person, string texts)
    {
        _person = person;
        _texts = texts; //comment of the person
    }

    //get the person
    public string GetPerson()
    {
        return _person;
    }

    //get the text
    public string GetTexts()
    {
        return _texts;
    }
}