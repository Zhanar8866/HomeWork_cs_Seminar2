/* Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
456 - 5
782 - 8
918 - 1
*/

int number = new Random().Next(100,1000);
Console.WriteLine(number);

string str = number.ToString();
Console.WriteLine(str[1]);

/* второй вариант решения - начиная со строки 10
int secondNumber = number / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {number} -> {secondNumber}");
*/