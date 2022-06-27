/* Задача 1: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

System.Console.WriteLine("Введите пятизначное число: ");

int[] numbers = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();

if (numbers.Length == 5)
{
    if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введите пятизначное число!!!");
}