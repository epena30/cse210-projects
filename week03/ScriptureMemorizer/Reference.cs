using System;
using System.Collections.Generic;
using System.Linq;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string referenceString)
    {
        var parts = referenceString.Split(new[] { " ", ":" }, StringSplitOptions.RemoveEmptyEntries);
        _book = parts[0];
        _chapter = int.Parse(parts[1]);
        _verse = int.Parse(parts[2]);
        _endVerse = _verse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}--{_endVerse}";
    }
}
