// Initialize vars
double num1;
double num2;

string answer;

double result;

// Prompt user to input to numbers
Console.WriteLine("Welcome to the C# Calculator App!");

Console.WriteLine("Please enter your first number.");


num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Your first number is: ");
Console.Write(num1);
Console.Write(".");
Console.WriteLine();

Console.WriteLine("Please enter your second number.");

num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Your second number is: ");
Console.Write(num2);
Console.Write(".");
Console.WriteLine();

Console.WriteLine("What type of operation would you like to perform?");
Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication or d for division.");

answer = Console.ReadLine();

// Perform the operation selected by the user
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
  result = 0;
  Console.WriteLine("Invalid input.");
}

Console.Write("The result is ");
Console.Write(result);
Console.Write("!");

Console.WriteLine();

Console.WriteLine("Enter any key to exit program.");
Console.ReadKey();