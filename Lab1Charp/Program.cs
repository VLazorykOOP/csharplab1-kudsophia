static void task1()
{
    Console.WriteLine("Task1 !");
    Console.WriteLine("Input a:");
    double a = double.Parse(Console.ReadLine());
    double radius = a / ( 2 * Math.Sqrt(3));
    Console.WriteLine($"Radius = : {radius}");
}
 static void task2()
 {
     Console.WriteLine("Task2 !");
             Console.WriteLine("Input a, b, c:");
             Console.Write("a = ");
             double a = Convert.ToDouble(Console.ReadLine());
             
             Console.Write("b = ");
             double b = Convert.ToDouble(Console.ReadLine());
             
             Console.Write("c = ");
             double c = Convert.ToDouble(Console.ReadLine());
             
             bool isTriangle = (a + b > c) && (b + c > a) && (a + c > b);
             if (isTriangle) {
                 Console.WriteLine("Yes, can exist.");
             }
             else {
                 Console.WriteLine("No, can`t exist.");
             }

 }

 static void task3()
 {
     Console.WriteLine("Task3 !");
     Console.Write("x=");
     float x = float.Parse(Console.ReadLine());
     Console.Write("y=");
     float y = float.Parse(Console.ReadLine());
     
     if ((x <= -15 && y <= 0 && y >= -15) || (x >= 0 && y <= 0 && y >= -15))
     {
         Console.WriteLine("Так");
     }
     else if ((x > -15 && x < 0 && y == 0) || (x == 0 && y > -15 && y < 0))
     {
         Console.WriteLine("На межі");
     }
     else
     {
         Console.WriteLine("Ні");
     }
 }
 static void task4()
 {
     Console.WriteLine("Task4 !");
     Console.WriteLine("Введіть ознаку транспортного засобу (a - автомобіль, в - велосипед, м - мотоцикл, с - літак, п - поїзд): ");
     char ознака = Console.ReadKey().KeyChar;

     int максимальнаШвидкість = 0;

     switch (ознака)
     {
         case 'а':
             максимальнаШвидкість = 200; // Швидкість автомобіля
             break;
         case 'в':
             максимальнаШвидкість = 30; // Швидкість велосипеда
             break;
         case 'м':
             максимальнаШвидкість = 250; // Швидкість мотоцикла
             break;
         case 'л':
             максимальнаШвидкість = 900; // Швидкість літака
             break;
         case 'п':
             максимальнаШвидкість = 300; // Швидкість поїзда
             break;
         default:
             Console.WriteLine("\nНеправильна ознака транспортного засобу!");
             return;
     }
     Console.WriteLine($"\nМаксимальна швидкість транспортного засобу з ознакою '{ознака}': {максимальнаШвидкість} км/год");
 }
 static void task5()
 {
     static int Cube(int x)
     {
         return x * x * x;
     }
     Console.WriteLine("Task5 !");
     Console.Write("Введіть ціле число: ");
     int num = Convert.ToInt32(Console.ReadLine());
     int result = Cube(num);
     Console.WriteLine($"Куб числа {num} дорівнює {result}.");
 }

 static void task6()
 {
     Console.WriteLine("Task6 !");
     Console.WriteLine("Введіть значення x:");
     double x = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Введіть значення y:"); 
     double y = Convert.ToDouble(Console.ReadLine());
     double result = ((1 / x * y) + (1 / (x * x + 1))) * (x + y);
     Console.WriteLine("Результат обчислення виразу: " + result);
 }
Console.WriteLine("Lab 1 !");
//task1();
//task2();
task3();
//task4();
//task5();
//task6();