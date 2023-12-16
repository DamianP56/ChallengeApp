namespace ChallengeApp.Tests
{

    public class EmployeeTests
    {
        [Test]
        public void TestAverageValue()
        {
            //arrange
            var employee = new Employee("Sebastian", "Maczka");
            employee.AddGrade(20);
            employee.AddGrade(20);
            employee.AddGrade(24);
            //act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreNotEqual(20, statistics.Average);
        }

        [Test]
        public void TestMinValue()
        {
            //arrange
            var employee = new Employee("Sebastian", "Maczka");
            employee.AddGrade(20);
            employee.AddGrade(15);
            employee.AddGrade(24);
            //act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreEqual(15, statistics.Min);
        }

        [Test]
        public void TestMaxValue()
        {
            //arrange
            var employee = new Employee("Sebastian", "Maczka");
            employee.AddGrade(20);
            employee.AddGrade(15);
            employee.AddGrade(24);
            //act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreEqual(24, statistics.Max);
        }
        [Test]

        public void TestLetter()
        {
            var employee = new Employee("Sebastian", "Maczka");
            float grade1 = 50;
            float grade2 = 60;
            float grade3 = 30;
            //arrange
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            //act
            var statisics = employee.GetStatistics();
            //assert
            Assert.That(statisics.AverageLetter, Is.EqualTo('C'));
        }
    }
}

















































