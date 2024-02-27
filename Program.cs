int num1;
int num2;

Console.WriteLine("Welcome to the C# Calculator App!");

Console.WriteLine("Please enter your first number.");


num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Your first number is: ");
Console.Write(num1);
Console.Write(".");
Console.WriteLine();

Console.WriteLine("Please enter your second number.");

num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Your second number is: ");
Console.Write(num2);
Console.Write(".");
Console.WriteLine();

Console.ReadKey();