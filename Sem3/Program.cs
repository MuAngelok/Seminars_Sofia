// Console.Write("Введите день недели: ");
// int number = int.Parse(Console.ReadLine()!);

// switch (number)
// {
//     case 6:{
//         Console.WriteLine("Это суббота!");
//         break;
//     }
//     case 7:{
//         Console.WriteLine("Это воскрксенье!");
//         break;
//     }
//     default:{
//         Console.WriteLine("Это будний день!");
//         break;
//     }
// }

// Задача 1: Напишите программу, которая по заданноиу номеру четверти, 
// показывает диапозон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int number = int.Parse(Console.ReadLine()!);

// switch (number)
// {
//     case 1:{
//         Console.WriteLine("x > 0 and y > 0");
//         break;
//     }
//     case 2:{
//         Console.WriteLine("y > 0 and x < 0");
//         break;
//     }
//     case 3:{
//         Console.WriteLine("y < 0 and x < 0");
//         break;
//     }
//     case 4:{
//         Console.WriteLine("x > 0 and y < 0");
//         break;
//     }
//     default:{
//         Console.WriteLine("Не верное число четверти!");
//         break;
//     }
// }

// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите первую точку");
// int ax = int.Parse(Console.ReadLine()!);
// int ay = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите вторую точку");
// int bx = int.Parse(Console.ReadLine()!);
// int by = int.Parse(Console.ReadLine()!);

// double ab = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2));
// Console.WriteLine($"{ab:f2}");

// Задача 3: Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2-> 1,4

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int index = 1;

while (index <= num){
    Console.WriteLine(Math.Pow(index, 2));
    index++;
}