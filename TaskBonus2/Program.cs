﻿// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. 
// Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
// Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – 
// на i-ом кусте выросло ai ягод.
// В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля 
// и нескольких собирающих модулей. Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, 
// собирает ягоды с этого куста и с двух соседних с ним.
// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. 
// Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. 
// Все ai не превосходят 1000.
Console.Clear();
Console.Write("Введите количество кустов черники, не менее 3 и не более 1000: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 2 && n <= 1000)
  {
    int max = 0;
    int [] ai = new int[n + 2];
    for (int i = 0; i < n; i++)
    {
      ai[i] = new Random().Next(1, 10);
      Console.Write($"{ai[i]}, ");
      ai[n] = ai[0];
      ai[n+1] = ai[1];
    }      
     for (int l = 1; l < n + 1; l++){
         int x = ai[l-1]+ai[l]+ai[l+1];
         if (x > max){
         max = x;
         }
    }
    Console.WriteLine($"максимум {max}");
  }
else
    Console.WriteLine("ошибка ввода");

    //подсмотрел идею увеличения массива

// dop
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]

// Console.WriteLine($"[{string.Join(", ", array)}]");
// int maxSum = 0;
// for (int i = 1; i < array.Length - 1; i++)
// {
//     if (array[i - 1] + array[i] + array[i + 1] > maxSum)
//         maxSum = array[i - 1] + array[i] + array[i + 1];
// }

// if (array[0] + array[1] + array[array.Length - 1] > maxSum)
//     maxSum = array[0] + array[1] + array[array.Length - 1];
// if (array[0] + array[array.Length - 2] + array[array.Length - 1] > maxSum)
//     maxSum = array[0] + array[array.Length - 2] + array[array.Length - 1];

// Console.WriteLine(maxSum);
