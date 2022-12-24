/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 - 5
78 - третьей цифры нет
32679 - 6
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string str = number.ToString();
int n = str.Length;

if (n>2)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}