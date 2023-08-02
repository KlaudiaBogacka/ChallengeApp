namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        // Maksymalna wartość ocen pracownika
        [Test]
        public void WhenICalledStatisticsMaxValueTest()
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
        // Minimalna wartość ocen pracownika
        public void WhenICalledStatisticsMinValueTest()
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
        // Średnia wartość ocen pracownika
        public void WhenICalledStatisticsAverageValue()
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
        public void WhenICalledStatisticsAverageShouldReturnLetterA()
        {
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(90);
            employee.AddGrade(85);
            employee.AddGrade(100);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]
        public void WhenICalledStatisticsAverageShouldReturnLetterB()
        {
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(64);
            employee.AddGrade(70);
            employee.AddGrade(79);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenICalledStatisticsAverageShouldReturnLetterC()
        {
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(40);
            employee.AddGrade(44);
            employee.AddGrade(58);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void WhenICalledStatisticsAverageShouldReturnLetterD()
        {
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(36);
            employee.AddGrade(24);
            employee.AddGrade(29);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('D', statistics.AverageLetter);
        }

        [Test]
        public void WhenICalledStatisticsAverageShouldReturnLetterE()
        {
            var employee = new Employee("Klaudia", "Bogacka");
            employee.AddGrade(9);
            employee.AddGrade(11);
            employee.AddGrade(15);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }
    }
}
