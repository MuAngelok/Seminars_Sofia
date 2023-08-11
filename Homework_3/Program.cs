// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num, r, sum = 0, t;
// Console.Write("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());
// if (num > 9999 && num < 100000)
// {
//     for (t = num; num != 0; num = num / 10)
//     {
//         r = num % 10;
//         sum = sum * 10 + r;
//     }
//     if (t == sum)
//         Console.Write($"{t} является палиндромом.");
//     else
//         Console.Write($"{t} не является палиндромом.");
// }
// else
//     Console.Write("Введите пятизначное число! ");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите первую точку");
// int ax = int.Parse(Console.ReadLine()!);
// int ay = int.Parse(Console.ReadLine()!);
// int az = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите вторую точку");
// int bx = int.Parse(Console.ReadLine()!);
// int by = int.Parse(Console.ReadLine()!);
// int bz = int.Parse(Console.ReadLine()!);

// double abz = Math.Sqrt(Math.Pow((ax - bx ), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
// Console.WriteLine($"{abz:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Таблица кубов:\n");
// for (int i = 1; i <= n; i++)
// {
//     int k = i * i * i;
//     Console.Write($"{ k}, ");
// }