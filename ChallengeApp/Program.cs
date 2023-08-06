using ChallengeApp;

Console.WriteLine("Witaj w naszym Programie do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Aplikacja liczy oceny Kierowników");
Console.WriteLine("Wpisz ocenę Pracownika");
Console.WriteLine("Aby zsumować oceny wpisz'q'");
Console.WriteLine("===========================================");
Console.WriteLine();

var supervisor = new Supervisor("Joanna", "Nowak");

try
{
    Supervisor sup = null;
    var name = sup.Surname;
}
catch(Exception exception)
{
    Console.WriteLine(exception.Message);
}
finally
{
    Console.WriteLine("Finally here");
}


while (true)
{
    Console.WriteLine("Podaj ocenę Kierownika");

    var input = Console.ReadLine();
    if (input == "q"  || input == "Q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched {e.Message}");
    }

}
var statistics = supervisor.GetStatistics();
Console.WriteLine("===========================================");
Console.WriteLine($"Wyniki Kierownika: {supervisor.Name} {supervisor.Surname}");
Console.WriteLine("===========================================");
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Ocena minimalna: {statistics.Min}");
Console.WriteLine($"Ocena maksymalna: {statistics.Max}");
Console.WriteLine("===========================================");