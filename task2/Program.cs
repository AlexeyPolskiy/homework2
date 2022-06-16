// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int paramIntN = rand.Next(1, 1000);
int result = ((paramIntN / 100) * 10) + (paramIntN % 10);
System.Console.WriteLine($"Случайное число {paramIntN}; результат условия задачи {result}");
