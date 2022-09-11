// Вывод четных чисел от 1 до N
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int startNumber=1;
int count = Convert.ToInt32(startNumber+1);
while (count <= number1);
{
if (count % 2 == 0)
{
    Console.WriteLine($"{count}");
}
     startNumber= startNumber+1;
}

// Не вышло, какая-то проблема с переменной которая должна считать значение числа до N