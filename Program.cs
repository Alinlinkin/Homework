// Выбор большего числа из 2, за основу возьмем что пользователь вводит 2 целых числа
Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

if (number1>number2)
{
     Console.Write(number1);
}
else
{
     Console.Write(number2);
}
