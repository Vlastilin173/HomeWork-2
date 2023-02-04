// // Задача 10:Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// //456 -> 5
// //782 -> 8
// //918 -> 1
Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int z = n % 100;
int x = z / 10;
    Console.WriteLine(x);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 999)
{
    int result = n/10;
    n=result; 
  }
if (n < 1000 && n >= 100)
{int z = n % 10;
Console.WriteLine($"Третья цифра числа: {z}");
}
else if (n < 100)
{Console.WriteLine("Третьей цифры нет");}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Будний день");
else if (n == 2)
    Console.WriteLine("Будний день");
else if (n == 3)
    Console.WriteLine("Будний день");
else if (n == 4)
    Console.WriteLine("Будний день");
else if (n == 5)
    Console.WriteLine("Будний день");
else if (n == 6)
    Console.WriteLine("Выходной день");
else
    Console.WriteLine("Выходной день");
