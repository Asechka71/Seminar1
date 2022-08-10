/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.*/
Console.WriteLine ("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int Max = number1;
if (number2 > Max) Max = number2;
if (number3 > Max) Max = number3; 
Console.WriteLine("Max = "+ Max);
