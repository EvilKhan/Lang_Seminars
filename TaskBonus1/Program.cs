// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
Console.Clear();
Console.WriteLine("Вводите любые натуральные числа, для завершения ввода, введите 0: ");
int x = Convert.ToInt32(Console.ReadLine());
int max1 = x;
int max2 = x;
while (x != 0)
  {
    x = Convert.ToInt32(Console.ReadLine());
      if (x > max1){
        max2 = max1;
        max1 = x;}
      else if (x > max2)
        max2 = x;
  }

  Console.WriteLine($"The END, second maximum = {max2}");