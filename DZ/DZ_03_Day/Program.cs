/* Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
6 - да
7 - да
1- нет 
*/

int number = new Random().Next(1,8);
Console.WriteLine(number);

if (number == 6 | number == 7)
{
    Console.WriteLine("да, выходной день");
}
else
{
    Console.WriteLine("нет, не выходной день");
}


/* второй вариант решения
Console.WriteLine("Введите день недели в цифрах: ");
int num = int.Parse(Console.ReadLine());
if (num > 7 || num < 1)
{
    Console.WriteLine("Введен не верный день недели");
}
else
if (num > 5 & num < 8)
{
    Console.WriteLine("да, выходной день");
}
else
{
    Console.WriteLine("нет, не выходной день");
}
*/