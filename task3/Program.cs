// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число не менее 3 знаков => ");
string paramStringN = Console.ReadLine();
int paramIntN = int.Parse(paramStringN);
if (paramIntN < 100) System.Console.WriteLine("Третьей цифры нет, повторите попытку");
else
{
    while (paramIntN > 999)
    {
        paramIntN = paramIntN / 10;
    }
    paramIntN = paramIntN % 10;
}
System.Console.WriteLine("Третья цифра => " + paramIntN);
