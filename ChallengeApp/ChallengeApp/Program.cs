using ChallengeApp;

Employee employee1 = new Employee(" Karol ", " 28", " Krawczyk ");
Employee employee2 = new Employee(" Matrta ", "40", " Kowalska ");
Employee employee3 = new Employee(" Irena " , "35", " Nowak ");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(4);
employee1.AddScore(2);

employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(8);

employee3.AddScore(9);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(4);
employee3.AddScore(1);

List<Employee> employees= new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var Employee in employees)
{
    if (Employee.Result > maxResult)
    {
        maxResult = Employee.Result;
        employeeWithMaxResult = Employee;
    }
}

if(employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    Console.WriteLine(" Najlepszy wynik uzyskał/a " + employee1.Name + employee1.Surname + employee1.Age + " lat " + " z wynikiem " + employee1.Result);
}
else
{
    if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
    {
        Console.WriteLine(" Najlepszy wynik uzyskał/a " + employee2.Name + employee2.Surname + employee2.Age + " lat " + " z wynikiem " + employee2.Result);
    }

    else
    {
        Console.WriteLine(" Najlepszy wynik uzyskał/a " + employee3.Name + employee3.Surname + employee3.Age + " lat " + " z wynikiem " + employee3.Result);
    }
}