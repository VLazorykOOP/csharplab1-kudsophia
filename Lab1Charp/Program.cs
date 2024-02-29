// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.WriteLine("Input a:");
    double a = double.Parse(Console.ReadLine());
    double radius = a / ( 2 * Math.Sqrt(3));
    Console.WriteLine($"Radius = : {radius}");
}
Console.WriteLine("Lab 1 !");
task1();