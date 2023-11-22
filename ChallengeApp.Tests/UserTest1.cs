using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var user = new User("Doktor", "fafra");
            user.AddScore(5);
            user.AddScore(6);
            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
    }
}

public class Tests
{
    [Test]
    public void WhenUserCollectGetsPenaltyPoints_ShouldCorrectResult()
    {
        // arrange
        var user = new User("Jackie", "chan");
        user.AddScore(3);
        user.AddScore(4);
        user.AddScore(-6);
        // act
        var result = user.Result;

        // assert
        Assert.AreEqual(1, result);
    }
}
