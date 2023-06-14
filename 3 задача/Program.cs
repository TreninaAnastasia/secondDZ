// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите любое  число от 1 до 7");
int a = int.Parse(Console.ReadLine()!);
if (a >= 6) 
{ 
    Console.WriteLine($" {a} -> да");
}
else
{
    Console.WriteLine($" {a} -> нет");
}

