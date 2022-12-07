// Задача 10

Console.WriteLine("Введите трехзначное число");
int Number = int.Parse(Console.ReadLine());
int firstPart = Number % 100 / 10;
Console.WriteLine(firstPart);