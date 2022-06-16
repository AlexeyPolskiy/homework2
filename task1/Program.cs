// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число => ");
string paramStringN = Console.ReadLine();
int paramIntN = int.Parse(paramStringN);
if (paramIntN < 100 || paramIntN > 999)
{
    System.Console.WriteLine("Вы вввели не верное число, повторите попытку");
    return;
}
int result = paramIntN % 100 / 10;
System.Console.WriteLine($"Ваше число {paramIntN}, цифра второго порядка {result}");


