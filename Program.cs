﻿// Выбор максимального числа из 3, за основу возьмем что пользователь вводит 3 целых числа
Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите третье число: ");
int number3 = Convert.ToInt32 (Console.ReadLine());

int max = number1;
if (number2> number1)
    max = number2;
if (number3> max)
    max = number3;

Console.Write (max);

