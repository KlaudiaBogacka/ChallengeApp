using ChallengeApp;

var employee = new Employee("Klaudia", "Bogacka");
employee.AddGrade("Klaudia");
employee.AddGrade(4.8);
employee.AddGrade(2000);
employee.AddGrade(6);

var statistics1 = employee.GetStatisticsWithForeach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine(" Get Statistic With Foreach ");
Console.WriteLine($"Average; {statistics1.Average:N2}");
Console.WriteLine($"Min; {statistics1.Min}");
Console.WriteLine($"Max; {statistics1.Max}");
Console.WriteLine("Get Statistics With For ");
Console.WriteLine($"Average; {statistics2.Average:N2}");
Console.WriteLine($"Min; {statistics2.Min}");
Console.WriteLine($"Max; {statistics2.Max}");
Console.WriteLine("Get Statistic With Do While");
Console.WriteLine($"Average; {statistics3.Average:N2}");
Console.WriteLine($"Min; {statistics3.Min}");
Console.WriteLine($"Max; {statistics3.Max}");
Console.WriteLine("Get Statistics With While");
Console.WriteLine($"Average; {statistics4.Average:N2}");
Console.WriteLine($"Min; {statistics4.Min}");
Console.WriteLine($"Max; {statistics4.Max}");