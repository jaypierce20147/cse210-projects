using System;

public class Word
{
    // storing the shown/hidden state
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    // Hides this word
    public void Hide()
    {

        _isHidden = true;

    }

    //returns whether this word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word as underscores if hidden
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }





}