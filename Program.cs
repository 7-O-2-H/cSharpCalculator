int num1;
int num2;

string answer;

int result;

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

Console.WriteLine("What type of operation would you like to perform?");
Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication or d for division.");

answer = Console.ReadLine();

if (answer == "a") 
{
  result = num1 + num2;
}
else if (answer == "s") 
{
  result = num1 - num2;
} 
else if (answer == "m") 
{
  result = num1 * num2;
} 
else if (answer == "d")
{
  result = num1 / num2;
} 
else 
{
  Console.WriteLine("Invalid input.");
}

Console.WriteLine("The result is " + result);
Console.ReadKey();