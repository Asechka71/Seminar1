﻿/* Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).*/
Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if 
  (number % 2 == 0)
Console.WriteLine("Данное число делится на 2 без остатка");
else 
   Console.WriteLine("Данное число не делится на 2 без остатка");