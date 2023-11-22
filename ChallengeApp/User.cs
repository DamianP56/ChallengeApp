namespace ChallengeApp
{
    public class User
    {

        public List<int> score = new List<int>();
        public string v1;
        public string v2;

        public User(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public User(string v1, string v2, int v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public User(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Age { get; set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}











