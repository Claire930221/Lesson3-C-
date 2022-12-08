/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("введите число:"); 
int n = Convert.ToInt32(Console.ReadLine());

if (n < 6)
{
    Console.WriteLine("будний"); 
}
 else if ((n == 6) || (n == 7))
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("ошибка");
    }
