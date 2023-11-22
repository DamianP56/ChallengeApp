using ChallengeApp;

User User = new User("Damian", "Palec", 26);
User user2 = new User("Rafał", "Patrzykalski", 29);
User user3 = new User("Donek", "Kortok", 23);

User.AddScore(3);
User.AddScore(4);
User.AddScore(8);

user2.AddScore(1);
user2.AddScore(8);
user2.AddScore(9);

user3.AddScore(10);
user3.AddScore(7);
user3.AddScore(6);

List<User> users = new List<User>()

{
    User,user2,user3
};

int maxResult = -1;
User? userWithmaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithmaxResult = user;
    }
}

Console.WriteLine(userWithmaxResult);
