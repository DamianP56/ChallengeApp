namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Adam";

        public string Surname => throw new NotImplementedException();

        public event EmployeBase.GradeAddedDelegate GradeAdded;

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {

                case "6+":
                    AddGrade(100);
                    break;
                case "5+":
                case "5-":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "4+":
                case "4-":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "+3":
                case "-3":
                    AddGrade(35);
                    break;
                case "3":
                    AddGrade(30);
                    break;
                case "2+":
                case "+2":
                    AddGrade(65);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong Grades");
            }
        }
    }
}
                    
                        




