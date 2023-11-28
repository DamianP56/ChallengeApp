namespace ChallengeApp.Tests
{

    public class TypeTest
    {
        [Test]
        public void WhenYouCollectGrades_ShouldReturnAverage()
        {
            //arrange
            var employee = new Employee("Sebastian", "Maczka");
            employee.AddGrade(20);
            employee.AddGrade(15);
            employee.AddGrade(24);
            //act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreNotEqual(20, statistics.Average);
        }

        [Test]
        public void WhenYouCollectGrades_ShouldReturnMin()
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
        public void WhenYouCollectGrades_ShouldReturnMax()
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
    }
}
    














































