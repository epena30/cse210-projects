using System;
using System.Collections.Generic;

public class Comment
{
    private string _Text;
    private string _Name;
    public Comment(string text, string name)
    {
        _Text = text;
        _Name = name;
     
    }
    public string Text => _Text;
    public string Name => _Name;
   
}



