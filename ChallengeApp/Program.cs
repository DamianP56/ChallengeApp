
using ChallengeApp;

var employee = new Employee("Sebastian", "Maczka");
employee.AddGrade("141");
employee.AddGrade("Sebastian");
employee.AddGrade(99);
employee.AddGrade(3.44);
employee.AddGrade(18.2);
employee.AddGrade(Math.PI);
employee.AddGrade(MathF.PI);

var statistics = employee.GetStatistics();


Console.WriteLine($"środkowa ocena; {statistics.Average:n2}");
Console.WriteLine($"niska: {statistics.Min}");
Console.WriteLine($"bardzo duża: {statistics.Max}");




