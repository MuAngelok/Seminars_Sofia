// int i = 0;

// while (i < 10)
// {
//     i += 2;
//     Console.WriteLine(i);
// }

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// // Математический способ
// int sqr = number * number;
// Console.WriteLine($"Квадрат числа {number} равен {sqr}(Математический способ)");

// // Библиотека
// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine($"Квадрат числа {number} равен {sqr1}(Библиотека)");

// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int first = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int second = int.Parse(Console.ReadLine()!);
// if (first == Convert.ToInt32(Math.Pow(second, 2)))
// {
// Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");

// 2 задание. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if(number == 1) Console.WriteLine("Понедельник");
// if(number == 2) Console.WriteLine("Вторник");
// if(number == 3) Console.WriteLine("Среда");
// if(number == 4) Console.WriteLine("Четверг");
// if(number == 5) Console.WriteLine("Пятница");
// if(number == 6) Console.WriteLine("Суббота");
// if(number == 7) Console.WriteLine("Воскресенье");
// else if(number<1 || number>7) Console.WriteLine("Введен неверный день недели ");

// 3 задание. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int num2 = - number;

// while (num2 <= number) {
// Console.Write($"{num2} ");
// num2++;
// }

// 4 задание. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает **последнюю** цифру этого числа.

// 456 -> 6

// 782 -> 2

// 918 -> 8

// Console.Write("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine()!);

// % - деление с остатком 456%100 = 45.6 -> 6
// / - целочисленное деление 456/10 = 45.6 -> 45

// int num = number%10;

// Console.WriteLine($"Последняя цифра числа {number} равна {num}");