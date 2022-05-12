// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число 1: ");
string NumStr = Console.ReadLine();
int firstNumber = int.Parse(NumStr);

Console.WriteLine("Введите число 2: ");
string NumStr2 = Console.ReadLine();
int secondNumber = int.Parse(NumStr2);

if ((firstNumber == secondNumber * secondNumber) || (secondNumber == firstNumber * firstNumber))
{
    Console.WriteLine($"число {firstNumber} является квадратом числа {secondNumber}");
}
else 
{   
     Console.WriteLine($"число {firstNumber} не является квадратом числа {secondNumber}");
}
