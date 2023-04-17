

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_SholudReturnCorrectSumResult()
        {
            // arrange
            var employee = new Employee("Klaudia", "Nowak", 31);
            employee.AddScore(10);
            employee.AddScore(4);
            employee.AddScore(-3);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
}