using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika:");

var employee = new EmployeeInFile("Jan", "Brzechwa");

employee.GradeAdded += EmployeGradeAded;
void EmployeGradeAded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowa ocene");
}

employee.AddGrade(0.6f);
employee.AddGrade("18");
employee.AddGrade("10");

while (true)
{
Console.WriteLine("Nacisnij q aby wyjść:");
var input = Console.ReadLine();
if (input == "q")
{
break;
}

try
{
employee.AddGrade(input);
}
catch (Exception e)
{
Console.WriteLine($"Something went wrong: {e.Message}");
}
Console.WriteLine($"Enter number or click q if you want finish task!");
}


var statistics = employee.GetStatistics();

Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");







