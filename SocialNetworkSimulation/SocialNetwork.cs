using System;
using System.Collections.Generic;

public class SocialNetwork
{
    public List<User> Users { get; private set; }

    public SocialNetwork()
    {
        Users = new List<User>();
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }
}
