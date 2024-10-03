using System;
using System.Collections.Generic;

public class Scripture
{
    //attributes for Scripture
    private Reference _reference;
    private List<Word> _words;

    //constructor
    public Scripture(Reference reference, string text)
    {   
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');

        foreach(string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }
    // method to hide randowm words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int randomIndex = random.Next(0, _words.Count);
            if ( !_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }
        }
    }
    //method to get display text (refrence & scriptures)
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim(); //method is used to remove any leading and trailing whitespace characters
    }

    //check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}