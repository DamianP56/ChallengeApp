namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        event EmployeBase.GradeAddedDelegate GradeAdded;

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(char grade);
        Statistics GetStatistics();
    }
}
    
        

    
    



