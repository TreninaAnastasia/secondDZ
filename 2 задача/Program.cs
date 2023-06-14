// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите любое  число");
int a = int.Parse(Console.ReadLine()!);
int b = a;
if ( a > 100)
{
   while ( b > 1000)
    {
    b = b / 10;
    continue;
    }
    int rez1 = b % 10;
    Console.WriteLine ($"{a} -> {rez1}");
}
else if ( a > 100 && a < 1000)
{
    int rez = a % 10;
    Console.WriteLine ($"{a} -> {rez}");
}
else 
{
     Console.WriteLine ($" {a} -> третьей цифры нет");
}
