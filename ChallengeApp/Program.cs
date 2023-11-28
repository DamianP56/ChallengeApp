using ChallengeApp;

var employee = new Employee("Sebastian", "Maczka");
employee.AddGrade(20);
employee.AddGrade(15);
employee.AddGrade(24);

var statistics = employee.GetStatistics();

Console.WriteLine($"Środkowa ocena; {statistics.Average:N2}");
Console.WriteLine($"niska: {statistics.Min}");
Console.WriteLine($"bardzo duża: {statistics.Max}");



