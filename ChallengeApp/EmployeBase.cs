namespace ChallengeApp
{
   
    public abstract class EmployeBase : IEmployee
    {
        public EmployeBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public abstract void AddGrade(float grade);


        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);


        public abstract void AddGrade(char grade);
        

        public abstract Statistics GetStatistics();
        
    }
}
