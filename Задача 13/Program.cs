//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Enter the Number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number > 99 ? number.ToString()[2] : '-') ;