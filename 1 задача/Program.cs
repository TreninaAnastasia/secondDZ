// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите любое трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int rez1 = a / 10;
int rez2 = rez1 % 10;
Console.WriteLine($" {a} -> {rez2}");



