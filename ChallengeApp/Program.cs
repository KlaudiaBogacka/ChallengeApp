using ChallengeApp;

Employee employee1 = new Employee("Klaudia", "Nowak", 31);
Employee employee2 = new Employee("Damian", "Kowalski", 33);
Employee employee3 = new Employee("Miłosz", "Nowy", 21);

employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(6);

employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(1);

employee3.AddScore(5);
employee3.AddScore(8);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(2);

List<Employee> employers = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in  employers)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najwięcej punktów zdobył");
Console.WriteLine( employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname );
Console.WriteLine( employeeWithMaxResult.Age + " lat ");
Console.WriteLine("Otrzymał " + employeeWithMaxResult.Result + " Punktów ");