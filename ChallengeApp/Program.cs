﻿using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika:");

var employee = new EmployeeInFile("Jan", "Brzechwa");
employee.AddGrade(0.5f);
employee.AddGrade(10);
employee.AddGrade("56");
employee.AddGrade("5");

var statistics = employee.GetStatistics();

Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");

//while (true)
//{
//Console.WriteLine("Nacisnij q aby wyjść:");
//var input = Console.ReadLine();
//if (input == "q")
//{
//break;
//}

//try
//{
//employee.AddGrade(input);
//}
//catch (Exception e)
//{
//Console.WriteLine($"Something went wrong: {e.Message}");
//}
//Console.WriteLine($"Enter number or click q if you want finish task!");
//}








