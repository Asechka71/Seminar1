/*Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.*/
Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)Console.WriteLine($"Большее число: {number1} Меньшее число: {number2}");

else if (number2 > number1)Console.WriteLine($"Большее число: {number2} Меньшее число: {number1}");