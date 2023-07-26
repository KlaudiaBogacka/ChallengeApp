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
            var employee1 = GetEmployee("Klaudia", "Nowak", 31);
            var employee2 = GetEmployee("Damian", "Kowalski", 33);
            // act


            //assert 
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
    
}
