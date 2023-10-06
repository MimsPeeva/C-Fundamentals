using System.Collections.Generic;

string command = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
switch (command)
{
    case "add":Add(firstNumber, secondNumber);break;
    case "multiply": Multiply(firstNumber, secondNumber); break;
    case "subtract": Subtract(firstNumber, secondNumber); break;
    case "divide": Divide(firstNumber, secondNumber); break;
}
static void Add(int first, int second )
{
    int result = first+ second;
    Console.WriteLine(result);
}
static void Multiply(int first, int second)
{
    int result = first * second;
    Console.WriteLine(result);
}
static void Subtract(int first, int second)
{
    int result = first - second;
    Console.WriteLine(result);
}
static void Divide(int first, int second)
{
    int result = first / second;
    Console.WriteLine(result);
}