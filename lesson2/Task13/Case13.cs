/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<=99)
{
    Console.WriteLine("третьей цифры нет");
}

else
{
    Console.WriteLine(n.ToString()[2]);
}

// пример с рандомным числом как на семинаре, только на любое число
/*int GetRandomNumber()

{
    return new Random().Next(); //
}
void ShowRandomeNumber(int number)
{
    Console.WriteLine($"Введите трёхзначное число: {number} ");
    string str = number.ToString();
    Console.WriteLine($"> {str[2]} ");
}

ShowRandomeNumber(GetRandomNumber());*/


