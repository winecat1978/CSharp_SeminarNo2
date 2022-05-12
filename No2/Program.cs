// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100,1000);
string str = num.ToString();

Console.WriteLine($"{num} -> {str[0]}{str[2]}");


