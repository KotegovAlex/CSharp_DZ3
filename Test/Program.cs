/* Задача 1: Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. без массива
14212 -> нет
12821 -> да
23432 -> да */

System.Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

if (number < 100000)
{
    if (((number / 10000) == (number % 10)) && ((number / 1000 % 10) == (number%100/10)))
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