﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/


///
void Task10()
{
    Console.WriteLine("введите целое число, трехзначное число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int x = (num1 % 100) / 10;
    Console.WriteLine($"второе число = {x}");
}
// Task10();





////////////////////////////////////////////////////////////
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

void Task13()
{
    Console.WriteLine("введите целое число, трехзначное число");
    int num13 = Convert.ToInt32(Console.ReadLine());
    
    if (num13 >= 100)
        {int x13 = (num13) % 10;
    Console.WriteLine($"третья цифра заданного числа = {x13}");}
    else {Console.WriteLine($"число не трехзначное, третьей цифры - нет");}
   
}
// Task13();



// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void Task15i()
{
    Console.WriteLine("введите цифру дня обозначаюшую день недели");
    int num15 = Convert.ToInt32(Console.ReadLine());
    if (num15>= 6)
        Console.WriteLine($" число {num15} соответствует выходному дню");

    else Console.WriteLine($" число {num15} соответствует буднему дню");
        }

Task15i();

