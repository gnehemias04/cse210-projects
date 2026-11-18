using System;

class Word
{
    //atributes
    private string _text;
    private bool _isHidden;

    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // methods
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        string hiddenText = "";
        if (_isHidden == false)
        {
            return _text + " ";
        }
        else
        {
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenText = hiddenText + "_";
            }
            return hiddenText + " ";
        }

    }
}