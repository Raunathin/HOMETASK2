/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(number);

if (numbers.Length > 2)
{
  Console.WriteLine("третья цифра: " + numbers[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}

