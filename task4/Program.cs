// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int prompt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int numberInt = prompt("Введите номер дня недели ");
if (numberInt < 1 || numberInt > 7)
{
    System.Console.WriteLine("Вы вввели не верный номер дня недели, повторите попытку");
    return;
}
if (numberInt == 6 || numberInt == 7) System.Console.WriteLine("Ыыходной.");
else System.Console.WriteLine("Нет, не выходной. Арбайтен.");
