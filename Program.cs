string ver = "1.0.1"; //everything was made by RozbitiOkno 24.11. 2025
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("=== " + (DateTime.Now) + " ===");
Console.WriteLine("RozitiOkno calculator v." + ver);
Console.WriteLine("=============================");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your first number");
Console.ResetColor();
double num1 = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your operation");
Console.ResetColor();
string oper = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Enter your second number");
Console.ResetColor();
double num2 = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Red;
switch (oper)
{
    default: 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR");
    Console.ResetColor();
    Console.WriteLine("Invalid operation- " + oper + " -Use operations like +,-,*,/");
    Console.ResetColor();
    break;
    case "+":
    Console.WriteLine("Operation complete! The result is: " + (num1 + num2));
    break;
    case "-":
    Console.WriteLine("Operation complete! The result is: " + (num1 - num2));
    break;
    case "*":
    Console.WriteLine("Operation complete! The result is: " + (num1 * num2));
    break;
    case "/":
    Console.WriteLine("Operation complete! The result is: " + (num1 / num2));
    break;
}
Console.ResetColor();
Console.WriteLine("Thanks for using RozbitiOkno calculator " + (ver));