namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void TwoNameAreLookSame()
        {
            //arrange
            string number1 = ("Jacek");
            string number2 = ("Jacek");
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void CompareOfIncorrectNumbers()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]

        public void CompareNumbersArenotEqual()
        {
            //arrange
            float A = 15.55f;
            float B = 10.2f;
            //act

            //assert
            Assert.AreNotEqual(A, B);
            }
    
        [Test]
        public void GetUserShouldReturnDiffrent()
{
        // arrange
        var user1 = new User("Damian", "trąbka");
        var user2 = new User("Damian", "trąbka");
        // act

        // assert
        Assert.AreNotEqual(user1, user2);
}

private User GetUser(string name)
{
    return new User(name);
}
    }
}


           
           





            









