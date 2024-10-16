using System;
using System.Collections.Generic;

public class Post
{
    public DateTime CreatedDate { get; private set; }
    public string Text { get; set; }
    public int Likes { get; private set; }
    public List<string> Comments { get; private set; }

    public Post(string text)
    {
        CreatedDate = DateTime.Now;
        Text = text;
        Likes = 0;
        Comments = new List<string>();
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public void Like()
    {
        Likes++;
    }
}
