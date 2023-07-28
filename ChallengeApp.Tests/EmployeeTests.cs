namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenICalledStatisticsShouldReturnMaxGrade()
        {
            // arrange
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            employee.AddGrade(1);

            // act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenICalledStatisticsShouldReturnMinGrade()
        {
            // arrange
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            employee.AddGrade(1);

            // act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void WhenICalledStatisticsShouldReturnAverageGrade()
        {
            // arrange
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            employee.AddGrade(1);

            // act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreNotEqual(4, statistics.Average );
        }

        [Test]
        public void WhenICalledStatisticsShouldReturnSumGrade()
        {
            // arrange
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            employee.AddGrade(1);

            // act
            var statistics = employee.GetStatistics();

            //assert 
            Assert.AreNotEqual(26, statistics.Sum);
        }
    }
}
