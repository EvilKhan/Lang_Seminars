// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
string? n = Console.ReadLine();
int n1 = Convert.ToInt32(n[0].ToString()); //берем первый char из string
int n2 = Convert.ToInt32(n[1].ToString()); //берем второй char из string
int n3 = Convert.ToInt32(n[3].ToString()); //берем четвертый char из string
int n4 = Convert.ToInt32(n[4].ToString()); //берем пятый char из string
if (n1 == n4 && n2 == n3)
    Console.WriteLine($"число {n} - полиндром");
else
    Console.WriteLine($"число {n} - не полиндром");
//Console.WriteLine($"{n1}, {n2}, {n3}, {n4}"); //для проверки конвертации из чара в интежер, 
                                                //так как и при переводе в utf8 условие сработает (без .tostring)