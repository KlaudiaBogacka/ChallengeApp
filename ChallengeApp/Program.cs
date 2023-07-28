using ChallengeApp;
using System.Runtime.CompilerServices;

var employee = new Employee("Klaudia", "Bogacka");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(4);
employee.AddGrade(8);
employee.AddGrade(1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Name of employee; {employee.Name} , {employee.Surname}");
Console.WriteLine($"Average; {statistics.Average:N2}");
Console.WriteLine($"Min; {statistics.Min}");
Console.WriteLine($"Max; {statistics.Max}");
Console.WriteLine($"Sum; {statistics.Sum}");

SetSth(out statistics);

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
    //statistics = new Statistics();
}