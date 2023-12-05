
using ChallengeApp;

var employee = new Employee("Sebastian", "Maczka");
employee.AddGrade("141");
employee.AddGrade("Sebastian");
employee.AddGrade(5);
employee.AddGrade('8');

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWile();

Console.WriteLine("Wynik : ");
Console.WriteLine($"środkowa ocena; {statistics.Average:n2}");
Console.WriteLine($"niska: {statistics.Min}");
Console.WriteLine($"bardzo duża: {statistics.Max}");

Console.WriteLine("Wynik1 : ");
Console.WriteLine($"środkowa ocena; {statistics1.Average:n2}");
Console.WriteLine($"niska: {statistics1.Min}");
Console.WriteLine($"bardzo duża: {statistics1.Max}");

Console.WriteLine("Wynik2 : ");
Console.WriteLine($"środkowa ocena; {statistics2.Average:n2}");
Console.WriteLine($"niska: {statistics2.Min}");
Console.WriteLine($"bardzo duża: {statistics2.Max}");

Console.WriteLine("Wynik3 : ");
Console.WriteLine($"środkowa ocena; {statistics3.Average:n2}");
Console.WriteLine($"niska: {statistics3.Min}");
Console.WriteLine($"bardzo duża: {statistics3.Max}");

Console.WriteLine("Wynik4 : ");
Console.WriteLine($"środkowa ocena; {statistics4.Average:n2}");
Console.WriteLine($"niska: {statistics4.Min}");
Console.WriteLine($"bardzo duża: {statistics4.Max}");





