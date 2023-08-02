namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;
            // act


            //assert 
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Klaudia", "Nowak");
            var employee2 = GetEmployee("Damian", "Kowalski");
            // act


            //assert 
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
    
}
