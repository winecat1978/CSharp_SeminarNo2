﻿//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0)
{
    if (num % 23 == 0) 
    {
       Console.WriteLine($"Число {num} кратно 7 и 23");
    }
}
else 
{       
    Console.WriteLine($"Число {num} не кратно 7 и 23 одновременно");
}
