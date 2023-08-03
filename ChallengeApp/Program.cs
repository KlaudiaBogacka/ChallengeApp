using ChallengeApp;

Console.WriteLine("Witaj w naszym Programie do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Aplikacja liczy oceny Pracowników");
Console.WriteLine("Wpisz ocenę Pracownika");
Console.WriteLine("Aby zsumować oceny wpisz'q'");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Klaudia", "Bogacka");

while (true)
{
    Console.WriteLine("Podaj ocenę Pracownika");

    var input = Console.ReadLine();
    if (input == "q"  || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine("===========================================");
Console.WriteLine($"Wyniki Pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine("===========================================");
Console.WriteLine($"Ocena podana za pomocą liter: { statistics.AverageLetter}");
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Ocena minimalna: {statistics.Min}");
Console.WriteLine($"Ocena maksymalna: {statistics.Max}");
Console.WriteLine("===========================================");
