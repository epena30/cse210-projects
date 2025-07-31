using System;
using System.Collections.Generic;

class Video
{
    private string _Title;
    private string _Author;
    private int _Length;
    private List<Comment> _commentList;

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        _commentList = new List<Comment>();
    }

    public string Title => _Title;
    public string Author => _Author;
    public int Length => _Length;


    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _commentList.Count;
    }
    public List<Comment> GetComments()
    {
        return _commentList;
    }
}

