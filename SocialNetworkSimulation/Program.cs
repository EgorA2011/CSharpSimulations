using System;

class Program
{
    static void Main(string[] args)
    {
        SocialNetwork network = new SocialNetwork();
        
        // Пример добавления пользователей
        User user1 = new User("Alice", "alice@example.com", "@alice");
        User user2 = new User("Bob", "bob@example.com", "@bob");

        network.AddUser(user1);
        network.AddUser(user2);

        // Пример создания постов
        user1.CreatePost("Hello, world!");
        user2.CreatePost("This is Bob's first post.");

        // Показать последние 5 постов
        user1.ShowLastFivePosts();
        user2.ShowLastFivePosts();
    }
}
