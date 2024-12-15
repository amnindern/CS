// See https://aka.ms/new-console-template for more information
int firstNumber;
int secondNumber;
string actionChoice;
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
actionChoice = Console.ReadLine();
if (actionChoice == "A" || actionChoice == "a")
{
    Console.WriteLine( firstNumber + " + " + secondNumber + " = " + (firstNumber+secondNumber));
} else if( actionChoice == "S" || actionChoice == "s")
{
    Console.WriteLine( firstNumber + " - " + secondNumber + " = " + (firstNumber-secondNumber));
}else if( actionChoice == "M" || actionChoice == "m")
{
    Console.WriteLine( firstNumber + " * " + secondNumber + " = " + (firstNumber*secondNumber));
}
else
{

    Console.WriteLine("Invalid choice");
}

Console.WriteLine("Press any Key to continue");
Console.ReadKey();