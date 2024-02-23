using System;

class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a:");
        double a = double.Parse(Console.ReadLine());
        
        double radius = a / ( 2 * Math.Sqrt(3));

        Console.WriteLine($"Radius = : {radius}");
    }
}