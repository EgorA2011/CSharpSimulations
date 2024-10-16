using System;
using System.Collections.Generic;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Nickname { get; set; }
    public List<Post> Posts { get; private set; }

    public User(string name, string email, string nickname)
    {
        Name = name;
        Email = email;
        Nickname = nickname;
        Posts = new List<Post>();
    }

    public void CreatePost(string text)
    {
        Posts.Add(new Post(text));
    }

    public void ShowLastFivePosts()
    {
        Console.WriteLine($"{Nickname}'s Last Posts:");
        for (int i = Math.Max(0, Posts.Count - 5); i < Posts.Count; i++)
        {
            Console.WriteLine($"- {Posts[i].Text} (Likes: {Posts[i].Likes}, Comments: {Posts[i].Comments.Count})");
        }
    }
}
