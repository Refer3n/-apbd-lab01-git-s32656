// See https://aka.ms/new-console-template for more information

using Tutorial2;

var numbers = new double[10];
    
Console.WriteLine("=== Number Input ===");

for (var i = 0; i < 10; i++)
{
    Console.Write($"[{i + 1}/10] Enter a number: ");
    Double.TryParse(Console.ReadLine(), out numbers[i]);
}

Console.WriteLine("Average: " + StatisticHelper.CalculateAverage(numbers));
Console.WriteLine("Max: " + StatisticHelper.CalculateMax(numbers));