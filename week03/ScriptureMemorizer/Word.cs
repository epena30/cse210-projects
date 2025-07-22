using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string _text;  
    public bool _isHidden;


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text;
     }
}
