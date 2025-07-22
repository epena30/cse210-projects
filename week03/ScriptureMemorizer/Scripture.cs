using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string referenceText, string text)
    {
        _reference = new Reference(referenceText);
        _words = text.Split(" ")
                    .Select(w => new Word(w))
                    .ToList();
    }
    public void HideRandomWord()
    {
        var random = new Random();
        var visibleWords = _words.Where(w => !w._isHidden).ToList();

        if (visibleWords.Any())
        {
            var WordsToHide = visibleWords[random.Next(visibleWords.Count)];
            WordsToHide.Hide();
        }
    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + "\n" + String.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
