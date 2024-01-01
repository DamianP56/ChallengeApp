namespace ChallengeApp
{

    public class EmployeeinMemory : EmployeBase
    {
        public delegate string WriteMessage(string message);

        private List<float> grades = new List<float>();

        public EmployeeinMemory(string name, string surname)
            : base(name, surname)
        {
            WriteMessage del;
            del = WriteMessageInConsole;
            del("Moj tekst");
            WriteMessageInConsole("Moj tekst2");
        }

        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message);
        }
        
    
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                AddGrade(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsfloat = (float)grade;
            this.AddGrade(gradeAsfloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsfloat = (float)grade;
            this.AddGrade(gradeAsfloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charGrade))
            {
                throw new Exception("String in not float");
            }
        }
        public override Statistics GetStatistics()
        {
            {
                var statistics = new Statistics();
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

                statistics.Average /= this.grades.Count;
                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }

                return statistics;
            }
        }
    }
}
