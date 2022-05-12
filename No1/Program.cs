int number = new Random().Next(10,100);
Console.WriteLine($"Сгенерированное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine($"First number: {firstDigit}, second number: {secondDigit}");

int max = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine($"max number is: {max}");
