namespace ChallengeApp
{
    public abstract class Person 
    {
       
        public Person(string name, string surname, int age, string sex) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        protected Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }


    }
}


