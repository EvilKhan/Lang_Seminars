﻿/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 2;
/*while (i <= n)
{    Console.Write($"{i} ");     //оба варианта работают, этот самый очевидный
     i = i + 2;
}*/
while(i <= n)
{    
    if (i % 2 == 0)
      Console.Write($"{i} ");
    i++;
}