// See https://aka.ms/new-console-template for more information

var numbers = new double[10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Enter some number: ");
    Double.TryParse(Console.ReadLine(), out numbers[i]);
}