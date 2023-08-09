using ChallengeApp;

Console.WriteLine("Witaj w naszym Programie do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Aplikacja liczy oceny Pracowników");
Console.WriteLine("Wpisz ocenę Pracownika");
Console.WriteLine("Aby zsumować oceny wpisz'q'");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Klaudia", "Bogacka");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.AddGrade(0.6f);

while (true)
{
   Console.WriteLine("Podaj ocenę Pracownika");
   var input = Console.ReadLine();
 if (input == "q"  || input == "Q")
 {
    break;
 }
 try
 {
    employee.AddGrade(input);
 }
 catch(Exception e)
 {
    Console.WriteLine($"Exception catched {e.Message}");
 }

}
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Wyniki Pracownika: {employee.Name} {employee.Surname}");
    Console.WriteLine("===========================================");
    Console.WriteLine($"Średnia ocen: {statistics.Average}");
    Console.WriteLine($"Ocena minimalna: {statistics.Min}");
    Console.WriteLine($"Ocena maksymalna: {statistics.Max}");
    Console.WriteLine("===========================================");