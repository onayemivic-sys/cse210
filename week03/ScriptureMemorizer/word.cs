using System;
public class Word
{
    //private fields.
    private string _text;
    private bool _isHidden;


    //Constructor initializes the word.

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //hides the word.

    public void Hide()
    {
        _isHidden = true;
    }

    // checks if the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }
    //Display the word or underscores.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenText = "";
            foreach (char character in _text)
            {
                if (char.IsLetter(character))
                {
                    hiddenText += "_";
                }
                else
                {
                    hiddenText += character;
                }
            }
            return hiddenText;
        }
        return _text;
    }
}